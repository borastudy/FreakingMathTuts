import os

BASE_DIR = "Assets/Scripts"
NAMESPACE = "FreakingMath"

def has_namespace(content):
    return "namespace " in content

def wrap_in_namespace(filepath):
    with open(filepath, "r", encoding="utf-8") as file:
        lines = file.readlines()

    if has_namespace("".join(lines)):
        return False  # already namespaced

    # find first non-comment, non-using, non-empty line
    start_index = 0
    for i, line in enumerate(lines):
        if line.strip() and not line.strip().startswith("using") and not line.strip().startswith("//"):
            start_index = i
            break

    indent = "    "
    new_lines = []
    new_lines.extend(lines[:start_index])
    new_lines.append(f"\nnamespace {NAMESPACE}\n{{\n")

    for line in lines[start_index:]:
        new_lines.append(indent + line)

    new_lines.append("}\n")

    with open(filepath, "w", encoding="utf-8") as file:
        file.writelines(new_lines)

    return True

def main():
    updated = 0
    for root, _, files in os.walk(BASE_DIR):
        for name in files:
            if name.endswith(".cs"):
                path = os.path.join(root, name)
                if wrap_in_namespace(path):
                    print(f"✅ Namespaced: {path}")
                    updated += 1
    print(f"\n✨ Done. Updated {updated} file(s).")

if __name__ == "__main__":
    main()
