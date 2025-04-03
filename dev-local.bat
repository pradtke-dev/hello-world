set LOCAL_DEV_DIR=%cd%
set INTEGRATION_TESTS_DIR=%LOCAL_DEV_DIR%\integration-tests

docker compose --profile development down

wt new-tab -p "docker" -d %LOCAL_DEV_DIR% docker compose --profile development up ^
    ; new-tab -p "dotnet" -d %LOCAL_DEV_DIR% cmd /k run-local.bat ^
    ; new-tab -p "cypress" -d %LOCAL_DEV_DIR% cmd /k run-cypress.bat
