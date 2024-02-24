docker run --rm -v "${PWD}":/local openapitools/openapi-generator-cli generate \
-i /local/catapi.json \
 -g csharp \
  --git-host github.com \
  --git-repo-id api-client-csharp \
  --git-user-id cheshire-cat-ai \
  --package-name CheshireCatApi \
  -o /local/.
