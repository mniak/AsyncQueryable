import sys
from lxml import etree

projects = [
    'AsyncQueryable',
    'AsyncQueryable.Fakes',
    'AsyncQueryable.MongoDb',
]
def bump_number(current, next):
    sp = current.split('.')
    major = int(sp[0])
    minor = int(sp[1]) if len(sp) > 1 else 0
    patch = int(sp[2]) if len(sp) > 2 else 0
    rev = int(sp[3]) if len(sp) > 3 else 0

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
        return next
    return '.'.join([str(x) for x in result[:size]])

def bump_proj(path, next):
    xml = etree.parse(path)
    vnodes = xml.xpath('/Project/PropertyGroup/Version')
    vnode = vnodes[0]
    version = bump_number(vnode.text, next)
    vnode.text = version
    xml.write(path)
    return version
    
def bump_all(version):
    for proj in projects:
        bump_proj('src/%s/%s.csproj' % (proj, proj), version)
              
if __name__ == '__main__':
    next = sys.argv[1] if len(sys.argv) > 1 else 'patch'
    bump_all(next)
