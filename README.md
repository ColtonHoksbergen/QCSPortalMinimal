# PublicPortalMinimum
Public version of the minimal portal for debugging.

There is only one page besides the index page. There is a link to it, called Details in the navigation bar on the top. Within this page, four jpg images are rendered from Base 64 strings in a custom component.

Refreshing the page multiple times with developer tools open should result in the following error, which I am investigating:

nd malformed component comment at Blazor:{"sequence":0,"type":"server","prerenderId":"509a14c41d624b73b9b628fd27d6d9e3","descriptor":"CfDJ8LGuF6p4LvxNnuR9y21FTj/OY1b6vMzn6dg6bdUAmFsZ9D5dixbkKjtbSzNu0TLuS2lz\u002B1C49rF5TZrCLm4ev8CbRMC58cTbFJDt0i8TmMxF/mPrpEViAUSJq1g70X9xKU/uiz1UDhcAxu82mJR8z0PySsvNKnj/nKReEeXynP/Zp6zVTYtNExew/aru1HiVgzcaotvrDKSRNXKPRbNc57B\u002Bx465BRedUijP4a\u002Bg\u002BCMTcoDYJy3qjjuA9f/5LS7G9n0SlbHAxR8R13xTwk3O9xLtVRDlXW6MaE/Qvq1gufGVqT3UsKganDAqRZ\u002B24js81OFqC2XyYcsO0TV8eTHZnyRrsvLXzC4SxJQ33tz3VXGM"}
    at zn (blazor.server.js:1:125395)
    at jn (blazor.server.js:1:123618)
    at jn (blazor.server.js:1:123654)
    at jn (blazor.server.js:1:123654)
    at jn (blazor.server.js:1:123654)
    at blazor.server.js:1:128188
    at blazor.server.js:1:128360
    at Zn (blazor.server.js:1:128364)
zn @ blazor.server.js:1
jn @ bl