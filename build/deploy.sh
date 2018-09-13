#!/bin/bash

SCRIPT_DIR=$(dirname "$0")/
ARTIFACTS_DIR=${SCRIPT_DIR}../artifacts/

Source=$1
ApiKey=$2

for f in ${ARTIFACTS_DIR}*.nupkg; do
    dotnet nuget push $f --source $Source --api-key $ApiKey    
done
