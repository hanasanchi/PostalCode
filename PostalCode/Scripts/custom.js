// Datepicker用
$(function () {
    $('.datepicker').datetimepicker({
        dayViewHeaderFormat: 'YYYY年 M月',
        format: 'YYYY/MM/DD',
        locale: 'ja',
        showTodayButton: true,
        toolbarPlacement: 'top',
        icons: {
            today: 'glyphicon glyphicon-time'
        }
    });
    $('.datepickerym').datetimepicker({
        dayViewHeaderFormat: 'YYYY年 M月',
        format: 'YYYY/MM',
        locale: 'ja',
        showTodayButton: true,
        toolbarPlacement: 'top',
        icons: {
            today: 'glyphicon glyphicon-time'
        }
    });
    $('.datepickertime').datetimepicker({
        format: 'HH:mm',
        locale: 'ja',
        showTodayButton: true,
        toolbarPlacement: 'top',
        icons: {
            today: 'glyphicon glyphicon-time'
        }
    });
});

//ファイルアップロード用
$(document).on('change', ':file', function () {
    var input = $(this),
        numFiles = input.get(0).files ? input.get(0).files.length : 1,
        label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
    input.parent().parent().next(':text').val(label);
});
