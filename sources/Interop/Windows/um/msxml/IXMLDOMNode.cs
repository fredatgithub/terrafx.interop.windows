// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF80-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct IXMLDOMNode
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMNode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMNode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMNode*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMNode*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMNode*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMNode*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMNode*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMNode*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMNode*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMNode*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMNode*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMNode*)Unsafe.AsPointer(ref this), childList);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), firstChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), lastChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMNode*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMNode*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMNode*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMNode*)Unsafe.AsPointer(ref this), hasChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMNode*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMNode*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMNode*)Unsafe.AsPointer(ref this), nodeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return lpVtbl->get_text((IXMLDOMNode*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return lpVtbl->put_text((IXMLDOMNode*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMNode*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMNode*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMNode*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMNode*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMNode*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMNode*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMNode*)Unsafe.AsPointer(ref this), xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMNode*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMNode*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMNode*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMNode*)Unsafe.AsPointer(ref this), isParsed);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMNode*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMNode*)Unsafe.AsPointer(ref this), prefixString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMNode*)Unsafe.AsPointer(ref this), nameString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMNode*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, DOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode*, ushort**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, ushort**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMNode*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;
        }
    }
}
