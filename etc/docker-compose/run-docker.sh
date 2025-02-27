#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p d7da6ec4-42a0-46da-80a9-13226bfa538c -t
    fi
    cd ../
fi

docker-compose up -d
