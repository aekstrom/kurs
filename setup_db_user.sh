#!/bin/bash

DB_USER="admin"
DB_PASSWORD="pass@word1"
ADMIN_PASSWORD="Pass@word1"
CSPROJ="kurs.csproj"
APPSETTINGS="appsettings.json"

function check_appsettings_exists() {
  if [ -f "./$APPSETTINGS" ]; then
    echo "Old appsettings.json found, removing it."
    rm -f -v "./$APPSETTINGS"
  fi
}

function build_appsettings() {
  echo "Building new appsettings.json"
  touch $APPSETTINGS
  cat << EOF >> "./$APPSETTINGS"
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "Microsoft": "Warning",
      "EPiServer": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
}
EOF
}

function create_db() {
  echo "##### Creating database in CMS at localhost:1433 (Docker) #####"
  dotnet-episerver "create-cms-database" "./$CSPROJ" "-S" "localhost,1433" "-U" "sa" "-P" "pass@word1" "-dn" "rb-paas-db"
}

function setup_admin(){
  echo "##### Creating admin user in CMS: View the contents of appsettings.json for your connection string #####"
  dotnet-episerver "add-admin-user" "-u" "$DB_USER" "-p" "$ADMIN_PASSWORD" "-e" "admin@admin.com" "-c" "EPiServerDB" "$CSPROJ"
}

check_appsettings_exists
build_appsettings
create_db
setup_admin
