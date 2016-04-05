$(function () {
    var ajaxFormSubmit = function () {
        var $form = $(this);
        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };
        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-fn-target"));
            $target.replaceWith(data);
        });
        return false;
    };

    $(function () {
        $("#search").focus();
    });

    $("form[data-fn-ajax='true'").submit(ajaxFormSubmit);
    //Removing bullets and underline from autocomplete
    $('.ui-autocomplete').css('list-style-type', 'none');
    $('.ui-autocomplete').css('text-decoration', 'none');

   
});