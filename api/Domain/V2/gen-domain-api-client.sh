#!/bin/bash
# gen-domain-api-client.sh

set -e

ROOT_PATH="$(pwd)"

docker run --rm \
  -v "$ROOT_PATH":/local openapitools/openapi-generator-cli generate \
  -i /local/api/Domain/V2/openapi.json \
  --ignore-file-override /local/.openapi-generator-ignore \
  --package-name Domain.Api.Client \
  --skip-validate-spec \
  -g csharp-netcore \
  -o /local/src/Integrations/Domain/V2/Domain.Api.Client
