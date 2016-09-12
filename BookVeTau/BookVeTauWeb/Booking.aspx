<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="BookVeTauWeb.Booking" Async="true"%>
<link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:300,400,500,700" type="text/css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
<link rel="stylesheet" href="https://code.getmdl.io/1.2.0/material.blue-red.min.css">
<script defer src="https://code.getmdl.io/1.2.0/material.min.js"></script>
<script src="https://code.jquery.com/jquery-3.1.0.min.js"></script>
<style>
	.mdl-list__item-text-body{
		color:#EEEEEE !important;
	}

	.CompanyName{
		color:white;
	}

	.row{
		width:45%;
		float:left;
	}

	body{
		font-family: 'Roboto', serif;
	}
	
	.header, p {
        font-family: 'Tangerine', serif;
        font-size: 50px;
		text-shadow: 4px 4px 4px #aaa;
		color: white;
    }
	
	.header p{
		position:relative;
		top : 30px;
	}
	
	.mdl-textfield{
		width : 80%;
	}
	
	.chieu-di{
		width : 35%;
		margin-right: 10%;
		margin-top: 20px;
		margin-bottom:20px;
	}
	
	.sl-ve-vip{
		width : 13%;
		margin-right: 19%;
		margin-top: 20px;
		margin-bottom:20px;
	}
	
	.mdl-list__item{
		cursor:pointer;
	}
</style>
<div class="header" style="text-align: center; height:80px; background-color:#2196F3">
	<p>Tulico Train Booking Online</p>
</div>
<div class="form" style="width: 70%;margin: 50px auto; padding-left: 135px;">
	<div class="row" style="clear:both;">
		<div>
			<label>Công ty</label>
		</div>
        
		<div class="mdl-textfield mdl-js-textfield" style="width:70%">
			<input class="mdl-textfield__input" type="text" id="txtCongTy">
			<label id='lbCongTy' class="mdl-textfield__label" for="sample1">VD : Tulico Tourist</label>
		</div>
        <img id="img-select-cty" src="Img/drop-down-arrow.png"/>
	</div>
    <div class="row">
		<div>
			<label>Số điện thoại</label>
		</div>
		<div class="mdl-textfield mdl-js-textfield">
			<input class="mdl-textfield__input" type="text" id="txtSdt" pattern="-?[0-9]*(\.[0-9]+)?">
			<label id='Label1' class="mdl-textfield__label" for="txtSdt">Chỉ điền nếu là khách lẻ</label>
            <span class="mdl-textfield__error">Số điện thoại phải là dạng số</span>
		</div>
	</div>
	<div class="row" style="clear:both;">
		<div>
			<label>Chiều</label>
		</div>
		<div>
			<label class="mdl-radio mdl-js-radio mdl-js-ripple-effect chieu-di" for="option-4">
			  <input type="radio" id="option-4" class="mdl-radio__button" name="options" value="3" checked>
			  <span class="mdl-radio__label">Hà Nội - Lào Cai</span>
			</label>
			<label class="mdl-radio mdl-js-radio mdl-js-ripple-effect chieu-di" for="option-5">
			  <input type="radio" id="option-5" class="mdl-radio__button" name="options" value="4">
			  <span class="mdl-radio__label">Lào Cai - Hà Nội</span>
			</label>
		</div>
	</div>
	<div class="row">
		<div>
			<label>Ngày đi</label>
		</div>
		<div class="mdl-textfield mdl-js-textfield">
			<input class="mdl-textfield__input" type="date" style="text-align:right;" id="txtNgayDi">
		</div>
	</div>
	<div class="row" style="clear:both;">
		<div>
			<label>Số vé</label>
		</div>
		<div class="mdl-textfield mdl-js-textfield">
			<input class="mdl-textfield__input" id="txtSoVe" type="number" pattern="-?[0-9]*(\.[0-9]+)?" style="text-align:right; margin-top: 4px;" value="1">
			<label class="mdl-textfield__label" for="txtSoVe">Số vé</label>
			<span class="mdl-textfield__error">Số vé phải là dạng số</span>
		</div>
	</div>
	<div class="row">
		<div>
			<label>Số vé VIP</label>
		</div>
		<div>
			<label class="mdl-radio mdl-js-radio mdl-js-ripple-effect sl-ve-vip" for="option-1">
			  <input type="radio" id="option-1" class="mdl-radio__button" name="veVIP" value="0" checked>
			  <span class="mdl-radio__label">0 vé</span>
			</label>
			<label class="mdl-radio mdl-js-radio mdl-js-ripple-effect sl-ve-vip" for="option-2">
			  <input type="radio" id="option-2" class="mdl-radio__button" name="veVIP" value="1">
			  <span class="mdl-radio__label">1 vé</span>
			</label>
			<label class="mdl-radio mdl-js-radio mdl-js-ripple-effect sl-ve-vip" for="option-3">
			  <input type="radio" id="option-3" class="mdl-radio__button" name="veVIP" value="2">
			  <span class="mdl-radio__label">2 vé</span>
			</label>
		</div>
	</div>
	<div class="row" style="clear:both;">
		<div>
			<label>Ghi chú</label>
		</div>
		<div class="mdl-textfield mdl-js-textfield">
			<textarea class="mdl-textfield__input" type="text" rows= "3" id="txtGhiChu" ></textarea>
			<label class="mdl-textfield__label" for="txtGhiChu">VD: 4 vé thường, 2 vé VIP</label>
		</div>
	</div>
	<div>
		<button class="mdl-button mdl-js-button mdl-button--raised mdl-button--colored" style="width: 200px;float: right; margin-right:19%; margin-top:68px;" onclick="bookingNow()">
			Đặt vé
		</button>
	</div>
	<div id="lst-cong-ty" style="position: fixed;top: 140px;z-index: 1000;left: 350px;background-color: rgb(66, 165, 245);height: 300px;overflow-y: scroll;display:none;">
		<ul class="demo-list-three mdl-list">
			<li class="mdl-list__item mdl-list__item--three-line">
				<span class="mdl-list__item-primary-content">
					<i class="material-icons mdl-list__item-avatar">person</i>
					<span class="CompanyName">Bryan Cranston</span>
					<span class="mdl-list__item-text-body">
						Bryan Cranston played the role of Walter in Breaking Bad. He is also known
						for playing Hal in Malcom in the Middle.
					</span>
				</span>
			</li>
			<li class="mdl-list__item mdl-list__item--three-line">
				<span class="mdl-list__item-primary-content">
					<i class="material-icons mdl-list__item-avatar">person</i>
					<span class="CompanyName">Bryan Cranston</span>
					<span class="mdl-list__item-text-body">
						Bryan Cranston played the role of Walter in Breaking Bad. He is also known
						for playing Hal in Malcom in the Middle.
					</span>
				</span>
			</li>
			<li class="mdl-list__item mdl-list__item--three-line">
				<span class="mdl-list__item-primary-content">
					<i class="material-icons mdl-list__item-avatar">person</i>
					<span class="CompanyName">Bryan Cranston</span>
					<span class="mdl-list__item-text-body">
						Bryan Cranston played the role of Walter in Breaking Bad. He is also known
						for playing Hal in Malcom in the Middle.
					</span>
				</span>
			</li>
			<li class="mdl-list__item mdl-list__item--three-line">
				<span class="mdl-list__item-primary-content">
					<i class="material-icons mdl-list__item-avatar">person</i>
					<span class="CompanyName">Bryan Cranston</span>
					<span class="mdl-list__item-text-body">
						Bryan Cranston played the role of Walter in Breaking Bad. He is also known
						for playing Hal in Malcom in the Middle.
					</span>
				</span>
			</li>
		</ul>
	</div>
</div>
<div class="footer" style="width:100%;background-color:#2196F3;color : white;clear:both;padding: 10px 20%;position: fixed;bottom: 0px;">
<b>Head office / TULICO</b><br />
<b>Add</b> / 5 Hang Can Street, Hoan Kiem, Ha Noi, Viet Nam<br />
<b>Tel</b> / (84) 04 38287806 /  39233409  / 0904.002.528 <b>Fax</b> / (84) 04 38260352<br />
<b>Rept office / DARLING HOTEL</b><br />
<b>Add</b> / Thac Bac Road, Sapa Town, Lao Cai Province<br />
<b>Tel</b> / (84) 020 3871349 / 020 3871961  <b>Fax</b> / (84) 020 3871963<br />
</div>
<style>
.demo-card-wide.mdl-card {
  width: 512px;
}
.demo-card-wide > .mdl-card__title {
  color: #fff;
  height: 176px;
  background: url('http://dulichsapagiare.com.vn/documents/1449682/0/SAPA-1+(1).jpg');
    background-size: 100%;
}
.demo-card-wide > .mdl-card__menu {
  color: #fff;
}

    .popup-content {
        clear:both;
        position:fixed;
        width:30%;
        left:35%;
        top:10%;
        z-index:10000;
    }

    .modal {
    
    position: fixed; /* Stay in place */
    z-index: 1000; /* Sit on top */
    left: 0;
    top: 0;
    width: 100%; /* Full width */
    height: 100%; /* Full height */
    overflow: auto; /* Enable scroll if needed */
    background-color: rgb(0,0,0); /* Fallback color */
    background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
}
</style>
<div id="myModal" class="modal">
<div class="popup-content">
    <div class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title">
            
        </div>
        <div class="mdl-card__supporting-text">
            <b>Từ ngày 12/09/2016 <br />
            Các công ty đặt vé tàu qua hệ thống website Tulico.vn sẽ được hưởng mức giá khuyến mại như sau:</b><br />
            - Đầu tuần : 430.000 VNĐ<br />
            - Cuối tuần : 480.000 VNĐ<br />
            - Đặt từ 24 vé trở lên : 430.000 VNĐ<br />
            <b>Khách hàng cá nhân dưới 8 vé</b><br />
            Chiều Hà Nội - Lào Cai các ngày Chủ nhật, T2, T3, T4 : 450.000 VNĐ<br />
            Chiều Lào Cai - Hà Nội các ngày T3, T4, T5 : 450.000 VNĐ<br />
            Các ngày khác : Liên hệ<br /><br />
            Hotline : (84) 0904.002.528 - (84) 04 38287806 - 04 39233409<br />
            Nhân viên CSKH : Mrs Loan, Mrs Hiền<br />

            <span style="color:red">(*) Chú ý : Nhân viên Nguyễn Quang Trung sẽ dừng giao dịch với các khách hàng đặt vé. Mọi giao dịch với nhân viên Nguyễn Quang Trung, Tulico không chịu trách nhiệm.</span>

        </div>
        <div class="mdl-card__actions mdl-card--border">
            <a class="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect" onclick="$('#myModal').hide()">
            OK, Bắt đầu đặt vé
            </a>
        </div>
        <div class="mdl-card__menu">
            <button class="mdl-button mdl-button--icon mdl-js-button mdl-js-ripple-effect">
            <%--<i class="material-icons">share</i>--%>
            </button>
        </div>
    </div>
</div>
</div>
<script>
    $(document).ready(function () {
        loadDSCty();
    });

    $('#img-select-cty').click(function () {
        $("#lst-cong-ty").show();
    })

    $(document).on("click", ".mdl-list__item", function () {
        var ele = jQuery(this).find(".CompanyName")[0];
        $('#lbCongTy').html("");
        $('#txtCongTy').val(ele.textContent);
        $("#lst-cong-ty").hide();
    });

    $(document).mouseup(function (e) {
        var container = $("#lst-cong-ty");

        if (!container.is(e.target) // if the target of the click isn't the container...
			&& container.has(e.target).length === 0) // ... nor a descendant of the container
        {
            container.hide();
        }
    });

    function loadDSCty() {

        $.ajax({
            type: "POST",
            url: "BookingService.asmx/getDSCty",
            data: "{}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: OnSuccessLoadDsCty,
            error: OnError
        });
    }

    function bookingNow() {

        $.ajax({
            type: "POST",
            url: "BookingService.asmx/booking",
            data: { 'chieu_di': $('input[name=options]:checked', 'body').val(), 'tenCty': $('#txtCongTy').val(), 'sdt': $('#txtSdt').val(), 'so_ve': $('#txtSoVe').val(), 'so_ve_vip': $('input[name=veVIP]:checked', 'body').val(), 'ngay_di': $('#txtNgayDi').val(), 'ghi_chu': $('#txtGhiChu').val() },
            contentType: "application/x-www-form-urlencoded",
            success: OnSuccess,
            error: OnError
        });
    }

    function OnSuccess(data, status) {
        alert("Cảm ơn bạn đã booking. Tulico sẽ kiểm tra và thông báo kết quả cho bạn trong thời gian sớm nhất");
    }

    function OnSuccessLoadDsCty(data, status) {
        data = data.d
        $('.demo-list-three').empty();
        stringhtml = "";
        for (i = 0; i < data.length; i++) {
            stringhtml += "<li class='mdl-list__item mdl-list__item--three-line'>";
            stringhtml += "<span class='mdl-list__item-primary-content'>";
            stringhtml += "<i class='material-icons mdl-list__item-avatar'>person</i>";
            stringhtml += "<span class='CompanyName'>" + data[i].TEN_CONG_TY + "</span>";
            stringhtml += "<span class='mdl-list__item-text-body'>";
            stringhtml += data[i].DIA_CHI;
            stringhtml += "</span>";
            stringhtml += "</span>";
            stringhtml += "</li>";
        }
        $('.demo-list-three').append(stringhtml);
    }

    function OnError(request, status, error) {
        alert(error);
    }
</script>