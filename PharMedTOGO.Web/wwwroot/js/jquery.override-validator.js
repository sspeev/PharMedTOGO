jQuery(function ($) {

    $.validator.addMethod('number', function (value, element) {
        return this.optional(element) || /^-?(?:\d+)(?:(\.|,)\d+)?$/.test(value);
    });

    $.validator.methods.range = function (value, element, paran) {
        return this.optional(element) || (Number(value.replace(',', '.')) >= Number(param[0]) && Number(value.replace(',', '.')) <= Number(paran[1]));
    }
});