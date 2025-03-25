set LOCAL_DEV_DIR=%cd%
set APP_DIR=%LOCAL_DEV_DIR%\App
set INTEGRATION_TESTS_DIR=%LOCAL_DEV_DIR%\integration-tests

wt new-tab -p "Command Prompt" -d %LOCAL_DEV_DIR% docker compose --profile development up ; new-tab -d %APP_DIR% dotnet run watch ; new-tab -d %INTEGRATION_TESTS_DIR% 
