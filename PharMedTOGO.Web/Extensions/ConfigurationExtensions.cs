namespace PharMedTOGO.Web.Extensions;

public static class ConfigurationExtensions
{
    /// <summary>
    /// Locates and loads environment variables from a .env file up the folder hierarchy.
    /// Loads them both into the process Environment and directly into the ASP.NET Core IConfigurationBuilder.
    /// </summary>
    public static IConfigurationBuilder AddEnvFile(this IConfigurationBuilder builder)
    {
        var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
        string? envPath = null;
        
        // Search upwards to find the .env file in parent directories
        while (directory != null)
        {
            var potentialPath = Path.Combine(directory.FullName, ".env");
            if (File.Exists(potentialPath))
            {
                envPath = potentialPath;
                break;
            }
            directory = directory.Parent;
        }

        if (envPath != null)
        {
            var envVariables = new Dictionary<string, string?>();
            foreach (var line in File.ReadAllLines(envPath))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                
                var parts = line.Split('=', 2);
                if (parts.Length == 2)
                {
                    var key = parts[0].Trim();
                    var value = parts[1].Trim();
                    
                    // Set the Environment Variable for libraries/tools that retrieve settings directly from Environment
                    Environment.SetEnvironmentVariable(key, value);
                    
                    // Translate double underscores to colons for ASP.NET Core configuration binding
                    var configKey = key.Replace("__", ":");
                    envVariables[configKey] = value;

                    // Fallback mapping for standard environment variables to their config paths
                    if (key == "GOOGLE_CLIENT_ID") envVariables["web:client_id"] = value;
                    if (key == "GOOGLE_CLIENT_SECRET") envVariables["web:client_secret"] = value;
                    if (key == "STRIPE_SECRET_KEY") envVariables["StripeSettings:SecretKey"] = value;
                    if (key == "STRIPE_PUBLISHABLE_KEY") envVariables["StripeSettings:PublishableKey"] = value;
                }
            }
            
            builder.AddInMemoryCollection(envVariables);
        }

        return builder;
    }
}
