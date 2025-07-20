C# project requires to use namespace? to be able to generate doc using DocFX

https://github.com/dotnet/docfx/blob/main/README.md
### ✅ Prerequisites
1. **.NET SDK** (6.0 or later recommended)
    - Install from: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. **DocFX**
    - Install via `dotnet`:
```bash
dotnet tool install -g docfx
```

📦 Step-by-Step Guide
1. Create a `docfx.json` Configuration File
Run this in the Unity project root:
```bash
docfx init
```

2. Customize docfx.json for Unity
Edit the docfx.json file to point to your Unity C# source files.
```json
{
  "$schema": "https://raw.githubusercontent.com/dotnet/docfx/main/schemas/docfx.schema.json",
  "metadata": [
    {
      "src": [
        {
          "src": "../",
          "files": [
            "Assembly-CSharp.csproj"
          ]
        }
      ],
      "dest": "api",
      "includePrivateMembers": true,
      "filter": "filterConfig.yml"
    }
  ],
  "build": {
    "content": [
      {
        "files": [
          "**/*.{md,yml}"
        ],
        "exclude": [
          "_site/**"
        ]
      }
    ],
    "resource": [
      {
        "files": [
          "images/**"
        ]
      }
    ],
    "output": "_site",
    "template": [
      "default",
      "modern"
    ],
    "globalMetadata": {
      "_appName": "Freaking Math Documentation",
      "_appTitle": "Freaking Math Documentation",
      "_enableSearch": true,
      "pdf": true
    }
  }
}
```

3. (Optional) Add filterConfig.yml to Exclude Unity-Generated Stuff
Create a filterConfig.yml file:
```yaml
apiRules:
  - exclude:
      uidRegex: ^UnityEngine.*
  - exclude:
      uidRegex: ^UnityEditor.*
  - exclude:
      uidRegex: ^System.*
```
This removes Unity's internal APIs from your docs.

4. Generate Metadata
This scans your code and generates API docs from XML comments.
```bash
docfx metadata
```

5. Build the Documentation Site
```bash
docfx build
```
Docs will be generated in the _site/ directory.

6. Preview Locally
```bash
docfx serve _site
```
Then open: [http://localhost:8080](http://localhost:8080)

7. ✅ All in **one command**:
```bash
docfx docfx.json --serve
```
This will does:
1. Generates metadata (`docfx metadata`)
2. Builds the site (`docfx build`)
3. Serves the site locally (`docfx serve _site`)
