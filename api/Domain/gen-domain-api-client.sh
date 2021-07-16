#!/bin/bash
# gen-domain-api-client.sh

set -e

ROOT_PATH="$(pwd)"

docker run --rm \
  -v "$ROOT_PATH":/local openapitools/openapi-generator-cli generate \
  -i /local/api/Domain/openapi-v1.json \
  --ignore-file-override /local/.openapi-generator-ignore \
  --package-name Domain.Api.V1.Client \
  --skip-validate-spec \
  -g csharp-netcore \
  -o /local/src/Integrations/Domain/Domain.Api.V1.Client

docker run --rm \
  -v "$ROOT_PATH":/local openapitools/openapi-generator-cli generate \
  -i /local/api/Domain/openapi-v2.json \
  --ignore-file-override /local/.openapi-generator-ignore \
  --package-name Domain.Api.V2.Client \
  --skip-validate-spec \
  -g csharp-netcore \
  -o /local/src/Integrations/Domain/Domain.Api.V2.Client
