from __future__ import print_function

import sys, os
import xml.etree.ElementTree as ET

projects = [
    "AsyncQueryable",
    "AsyncQueryable.Fakes",
	"AsyncQueryable.MongoDb",
]
def bump_number(current, next):
    if next.startswith('v'):
        next = next[1:]
    
    sp = current.split('.')
    if not sp[0].isdigit():
        print("The current version '{0}' could not be parsed.".format(current), file=sys.stderr)
        sys.exit(-1)

    major = int(sp[0])
    minor = int(sp[1]) if len(sp) > 1 else 0
    patch = int(sp[2]) if len(sp) > 2 else 0
    rev   = int(sp[3]) if len(sp) > 3 else 0

    result = []
    size = len(sp)
    if next == 'major':
        result = [major+1, 0, 0, 0]
    elif next == 'minor':
        result = [major, minor+1, 0, 0]
        size = max(size, 2)
    elif next == 'patch':
        result = [major, minor, patch+1, 0]
        size = max(size, 3)
    elif next == 'revision':
        result = [major, minor, patch, rev+1]
        size = max(size, 4)
    else:
        spnext = next.split('.')
        if not all(num.isdigit() for num in spnext):
            print("Could not parse version expression '{0}'.".format(next), file=sys.stderr)
            sys.exit(-2)
        if len(spnext) < 1 or len(spnext) > 4:
            print("The version expression '{0}' is invalid. It must be 1-4 segments long.".format(next), file=sys.stderr)
            sys.exit(-3)
        return next
    return '.'.join([str(x) for x in result[:size]])

def bump_proj(path, next):
    xml = ET.parse(path)
    vnode = xml.find('PropertyGroup/Version')
    old_version = vnode.text
    new_version = bump_number(old_version, next)
    vnode.text = new_version
    xml.write(path)
    relpath = os.path.relpath(path, os.getcwd())
    print("Bumped '{0}' version '{1}' => '{2}".format(relpath, old_version, new_version))
    return new_version
    
def bump_all(version):
    for proj in projects:
        bump_proj('src/%s/%s.csproj' % (proj, proj), version)
              
if __name__ == '__main__':
    next = sys.argv[1] if len(sys.argv) > 1 else 'patch'
    bump_all(next)
