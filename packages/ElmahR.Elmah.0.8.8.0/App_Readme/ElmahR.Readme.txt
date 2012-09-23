ElmahR.Elmah README
===================

Please look for the following marker strings in web.config, and replace them
with meaningful values:

    http://TARGET_DASHBOARD_URL
Must be the url to reach the PostError.ashx handler from the Elmahr 
dashboard you are targeting.

    http://SOURCE_IDENTIFIER_URI_AS_LISTED_IN_DASHBOARD_CONFIG
A unique string identifying you application inside ElmahR dashboard
configuration, please check with the dashboard mantainer to know which
value you should put there.



This package depends on ELMAH, and needs ELMAH to be properly configured 
in order to work. To help having a smooth configuration experience, this 
package automatically adds ELMAH 'errorLog' items, in particular:

1. the section definition
2. the module declarations (system.web and system.webserver)
3. the assignment to a concrete module

The first 2 items should not be a problem, while it is possible that the
3rd item conflicts with any other equivalent concrete module you may
already have in place. Please check if this happens, and remove the extra
module assignment introduced by this package.



Please refer to https://bitbucket.org/wasp/elmahr/wiki/Home for more details.