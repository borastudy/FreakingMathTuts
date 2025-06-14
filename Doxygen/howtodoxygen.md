# Documentation
1. Install Doxygen if not yet
```bash
brew install doxygen
```
2. To generate default config file if not yet
```bash
doxygen -g
```
3. To generate document
```bash
doxygen Doxyfile
```

4. To open document
```bash
open ./docs/html/index.html
```



# Sample Doxyfile 1.9.1
# Project related configuration options
PROJECT_NAME           = "Freaking Math Documentation"
OUTPUT_DIRECTORY       = ./docs
EXTRACT_ALL            = YES
GENERATE_HTML          = YES
INPUT                  = ../Assets/Scripts
RECURSIVE              = YES

# Graphviz configuration
HAVE_DOT               = YES
DOT_PATH               = /usr/local/bin
DOT_GRAPH_MAX_NODES    = 50
MAX_DOT_GRAPH_DEPTH    = 0
CLASS_GRAPH            = YES
COLLABORATION_GRAPH    = YES
GROUP_GRAPHS           = YES
UML_LOOK               = YES
TEMPLATE_RELATIONS     = YES
INCLUDE_GRAPH          = YES
INCLUDED_BY_GRAPH      = YES
CALL_GRAPH             = YES
CALLER_GRAPH           = YES
GRAPHICAL_HIERARCHY    = YES
DIRECTORY_GRAPH        = YES

SOURCE_BROWSER         = YES
REFERENCES_RELATION    = YES
EXTRACT_PRIVATE        = YES
EXTRACT_PRIV_VIRTUAL   = YES
EXTRACT_PACKAGE        = YES
EXTRACT_STATIC         = YES
EXTRACT_LOCAL_CLASSES  = YES