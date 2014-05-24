window.fbAsyncInit = function () {
    FB.init({
        appId: '314407772044158', // App ID
        status: true, // check login status
        cookie: true, // enable cookies to allow the server to access the session
        xfbml: true,  // parse XFBML
        frictionlessRequests: true
    });
    jQuery(document).trigger('FBSDKLoaded');
};

// Load the SDK Asynchronously
(function (d) {
    var js, id = 'facebook-jssdk', ref = d.getElementsByTagName('script')[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement('script'); js.id = id; js.async = true;
    js.src = "//connect.facebook.net/en_US/all.js";
    ref.parentNode.insertBefore(js, ref);
} (document));

(function ($) {
    $(document).bind('FBSDKLoaded', function () {
        FB.login(function (response) {

            if (response.status == 'connected') {
                // the user is logged in and has authenticated your
                // app, and response.authResponse supplies
                // the user's ID, a valid access token, a signed
                // request, and the time the access token 
                // and signed request each expire
                var uid = response.authResponse.userID;
                var accessToken = response.authResponse.accessToken;

                // TODO: Handle the access token
                // Do a post to the server to finish the logon
                // This is a form post since we don't want to use AJAX
                var form = document.createElement("form");
                form.setAttribute("method", 'post');
                form.setAttribute("action", 'FacebookLogin.ashx');

                var field = document.createElement("input");
                field.setAttribute("type", "hidden");
                field.setAttribute("name", 'accessToken');
                field.setAttribute("value", accessToken + '|' + uid);
                form.appendChild(field);

                document.body.appendChild(form);
                form.submit();
            }

        }, { scope: 'user_friends' });
    });

})(jQuery);
