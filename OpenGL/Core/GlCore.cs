using System;
using System.Runtime.InteropServices;

namespace OpenGL
{
    public partial class Gl
    {
        internal static partial class NativeMethods
        {
            [DllImport(Gl.Library, EntryPoint = "glActiveShaderProgram", ExactSpelling = true)]
            internal static extern void ActiveShaderProgram(UInt32 pipeline, UInt32 program);

            [DllImport(Gl.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal static extern void ActiveTexture(Int32 texture);

            [DllImport(Gl.Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
            internal static extern void AttachShader(UInt32 program, UInt32 shader);

            [DllImport(Gl.Library, EntryPoint = "glBeginConditionalRender", ExactSpelling = true)]
            internal static extern void BeginConditionalRender(UInt32 id, OpenGL.ConditionalRenderType mode);

            [DllImport(Gl.Library, EntryPoint = "glEndConditionalRender", ExactSpelling = true)]
            internal static extern void EndConditionalRender();

            [DllImport(Gl.Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
            internal static extern void BeginQuery(OpenGL.QueryTarget target, UInt32 id);

            [DllImport(Gl.Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
            internal static extern void EndQuery(OpenGL.QueryTarget target);

            [DllImport(Gl.Library, EntryPoint = "glBeginQueryIndexed", ExactSpelling = true)]
            internal static extern void BeginQueryIndexed(OpenGL.QueryTarget target, UInt32 index, UInt32 id);

            [DllImport(Gl.Library, EntryPoint = "glEndQueryIndexed", ExactSpelling = true)]
            internal static extern void EndQueryIndexed(OpenGL.QueryTarget target, UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glBeginTransformFeedback", ExactSpelling = true)]
            internal static extern void BeginTransformFeedback(OpenGL.BeginFeedbackMode primitiveMode);

            [DllImport(Gl.Library, EntryPoint = "glEndTransformFeedback", ExactSpelling = true)]
            internal static extern void EndTransformFeedback();

            [DllImport(Gl.Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
            internal static extern void BindAttribLocation(UInt32 program, UInt32 index, String name);

            [DllImport(Gl.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal static extern void BindBuffer(OpenGL.BufferTarget target, UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glBindBufferBase", ExactSpelling = true)]
            internal static extern void BindBufferBase(OpenGL.BufferTarget target, UInt32 index, UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glBindBufferRange", ExactSpelling = true)]
            internal static extern void BindBufferRange(BufferTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);

            [DllImport(Gl.Library, EntryPoint = "glBindBuffersBase", ExactSpelling = true)]
            internal static extern void BindBuffersBase(OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers);

            [DllImport(Gl.Library, EntryPoint = "glBindBuffersRange", ExactSpelling = true)]
            internal static extern void BindBuffersRange(OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, IntPtr[] sizes);

            [DllImport(Gl.Library, EntryPoint = "glBindFragDataLocation", ExactSpelling = true)]
            internal static extern void BindFragDataLocation(UInt32 program, UInt32 colorNumber, String name);

            [DllImport(Gl.Library, EntryPoint = "glBindFragDataLocationIndexed", ExactSpelling = true)]
            internal static extern void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);

            [DllImport(Gl.Library, EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
            internal static extern void BindFramebuffer(OpenGL.FramebufferTarget target, UInt32 framebuffer);

            [DllImport(Gl.Library, EntryPoint = "glBindImageTexture", ExactSpelling = true)]
            internal static extern void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, Boolean layered, Int32 layer, OpenGL.BufferAccess access, OpenGL.PixelInternalFormat format);

            [DllImport(Gl.Library, EntryPoint = "glBindImageTextures", ExactSpelling = true)]
            internal static extern void BindImageTextures(UInt32 first, Int32 count, UInt32[] textures);

            [DllImport(Gl.Library, EntryPoint = "glBindProgramPipeline", ExactSpelling = true)]
            internal static extern void BindProgramPipeline(UInt32 pipeline);

            [DllImport(Gl.Library, EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
            internal static extern void BindRenderbuffer(OpenGL.RenderbufferTarget target, UInt32 renderbuffer);

            [DllImport(Gl.Library, EntryPoint = "glBindSampler", ExactSpelling = true)]
            internal static extern void BindSampler(UInt32 unit, UInt32 sampler);

            [DllImport(Gl.Library, EntryPoint = "glBindSamplers", ExactSpelling = true)]
            internal static extern void BindSamplers(UInt32 first, Int32 count, UInt32[] samplers);

            [DllImport(Gl.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal static extern void BindTexture(OpenGL.TextureTarget target, UInt32 texture);

            [DllImport(Gl.Library, EntryPoint = "glBindTextures", ExactSpelling = true)]
            internal static extern void BindTextures(UInt32 first, Int32 count, UInt32[] textures);

            [DllImport(Gl.Library, EntryPoint = "glBindTextureUnit", ExactSpelling = true)]
            internal static extern void BindTextureUnit(UInt32 unit, UInt32 texture);

            [DllImport(Gl.Library, EntryPoint = "glBindTransformFeedback", ExactSpelling = true)]
            internal static extern void BindTransformFeedback(OpenGL.NvTransformFeedback2 target, UInt32 id);

            [DllImport(Gl.Library, EntryPoint = "glBindVertexArray", ExactSpelling = true)]
            internal static extern void BindVertexArray(UInt32 array);

            [DllImport(Gl.Library, EntryPoint = "glBindVertexBuffer", ExactSpelling = true)]
            internal static extern void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, IntPtr stride);

            [DllImport(Gl.Library, EntryPoint = "glVertexArrayVertexBuffer", ExactSpelling = true)]
            internal static extern void VertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

            [DllImport(Gl.Library, EntryPoint = "glBindVertexBuffers", ExactSpelling = true)]
            internal static extern void BindVertexBuffers(UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);

            [DllImport(Gl.Library, EntryPoint = "glVertexArrayVertexBuffers", ExactSpelling = true)]
            internal static extern void VertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);

            [DllImport(Gl.Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
            internal static extern void BlendColor(Single red, Single green, Single blue, Single alpha);

            [DllImport(Gl.Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
            internal static extern void BlendEquation(OpenGL.BlendEquationMode mode);

            [DllImport(Gl.Library, EntryPoint = "glBlendEquationi", ExactSpelling = true)]
            internal static extern void BlendEquationi(UInt32 buf, OpenGL.BlendEquationMode mode);

            [DllImport(Gl.Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
            internal static extern void BlendEquationSeparate(OpenGL.BlendEquationMode modeRGB, OpenGL.BlendEquationMode modeAlpha);

            [DllImport(Gl.Library, EntryPoint = "glBlendEquationSeparatei", ExactSpelling = true)]
            internal static extern void BlendEquationSeparatei(UInt32 buf, OpenGL.BlendEquationMode modeRGB, OpenGL.BlendEquationMode modeAlpha);

            [DllImport(Gl.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal static extern void BlendFunc(OpenGL.BlendingFactorSrc sfactor, OpenGL.BlendingFactorDest dfactor);

            [DllImport(Gl.Library, EntryPoint = "glBlendFunci", ExactSpelling = true)]
            internal static extern void BlendFunci(UInt32 buf, OpenGL.BlendingFactorSrc sfactor, OpenGL.BlendingFactorDest dfactor);

            [DllImport(Gl.Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
            internal static extern void BlendFuncSeparate(OpenGL.BlendingFactorSrc srcRGB, OpenGL.BlendingFactorDest dstRGB, OpenGL.BlendingFactorSrc srcAlpha, OpenGL.BlendingFactorDest dstAlpha);

            [DllImport(Gl.Library, EntryPoint = "glBlendFuncSeparatei", ExactSpelling = true)]
            internal static extern void BlendFuncSeparatei(UInt32 buf, OpenGL.BlendingFactorSrc srcRGB, OpenGL.BlendingFactorDest dstRGB, OpenGL.BlendingFactorSrc srcAlpha, OpenGL.BlendingFactorDest dstAlpha);

            [DllImport(Gl.Library, EntryPoint = "glBlitFramebuffer", ExactSpelling = true)]
            internal static extern void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenGL.ClearBufferMask mask, OpenGL.BlitFramebufferFilter filter);

            [DllImport(Gl.Library, EntryPoint = "glBlitNamedFramebuffer", ExactSpelling = true)]
            internal static extern void BlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenGL.ClearBufferMask mask, OpenGL.BlitFramebufferFilter filter);

            [DllImport(Gl.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal static extern void BufferData(OpenGL.BufferTarget target, IntPtr size, IntPtr data, OpenGL.BufferUsageHint usage);

            [DllImport(Gl.Library, EntryPoint = "glNamedBufferData", ExactSpelling = true)]
            internal static extern void NamedBufferData(UInt32 buffer, Int32 size, IntPtr data, OpenGL.BufferUsageHint usage);

            [DllImport(Gl.Library, EntryPoint = "glBufferStorage", ExactSpelling = true)]
            internal static extern void BufferStorage(OpenGL.BufferTarget target, IntPtr size, IntPtr data, UInt32 flags);

            [DllImport(Gl.Library, EntryPoint = "glNamedBufferStorage", ExactSpelling = true)]
            internal static extern void NamedBufferStorage(UInt32 buffer, Int32 size, IntPtr data, UInt32 flags);

            [DllImport(Gl.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal static extern void BufferSubData(OpenGL.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glNamedBufferSubData", ExactSpelling = true)]
            internal static extern void NamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
            internal static extern OpenGL.FramebufferErrorCode CheckFramebufferStatus(OpenGL.FramebufferTarget target);

            [DllImport(Gl.Library, EntryPoint = "glCheckNamedFramebufferStatus", ExactSpelling = true)]
            internal static extern OpenGL.FramebufferErrorCode CheckNamedFramebufferStatus(UInt32 framebuffer, OpenGL.FramebufferTarget target);

            [DllImport(Gl.Library, EntryPoint = "glClampColor", ExactSpelling = true)]
            internal static extern void ClampColor(OpenGL.ClampColorTarget target, OpenGL.ClampColorMode clamp);

            [DllImport(Gl.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal static extern void Clear(OpenGL.ClearBufferMask mask);

            [DllImport(Gl.Library, EntryPoint = "glClearBufferiv", ExactSpelling = true)]
            internal static extern void ClearBufferiv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glClearBufferuiv", ExactSpelling = true)]
            internal static extern void ClearBufferuiv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glClearBufferfv", ExactSpelling = true)]
            internal static extern void ClearBufferfv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glClearBufferfi", ExactSpelling = true)]
            internal static extern void ClearBufferfi(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);

            [DllImport(Gl.Library, EntryPoint = "glClearNamedFramebufferiv", ExactSpelling = true)]
            internal static extern void ClearNamedFramebufferiv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glClearNamedFramebufferuiv", ExactSpelling = true)]
            internal static extern void ClearNamedFramebufferuiv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glClearNamedFramebufferfv", ExactSpelling = true)]
            internal static extern void ClearNamedFramebufferfv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glClearNamedFramebufferfi", ExactSpelling = true)]
            internal static extern void ClearNamedFramebufferfi(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);

            [DllImport(Gl.Library, EntryPoint = "glClearBufferData", ExactSpelling = true)]
            internal static extern void ClearBufferData(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glClearNamedBufferData", ExactSpelling = true)]
            internal static extern void ClearNamedBufferData(UInt32 buffer, OpenGL.SizedInternalFormat internalFormat, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glClearBufferSubData", ExactSpelling = true)]
            internal static extern void ClearBufferSubData(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, IntPtr offset, IntPtr size, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glClearNamedBufferSubData", ExactSpelling = true)]
            internal static extern void ClearNamedBufferSubData(UInt32 buffer, OpenGL.SizedInternalFormat internalFormat, IntPtr offset, Int32 size, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal static extern void ClearColor(Single red, Single green, Single blue, Single alpha);

            [DllImport(Gl.Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
            internal static extern void ClearDepth(Double depth);

            [DllImport(Gl.Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal static extern void ClearDepthf(Single depth);

            [DllImport(Gl.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal static extern void ClearStencil(Int32 s);

            [DllImport(Gl.Library, EntryPoint = "glClearTexImage", ExactSpelling = true)]
            internal static extern void ClearTexImage(UInt32 texture, Int32 level, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glClearTexSubImage", ExactSpelling = true)]
            internal static extern void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glClientWaitSync", ExactSpelling = true)]
            internal static extern OpenGL.ArbSync ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);

            [DllImport(Gl.Library, EntryPoint = "glClipControl", ExactSpelling = true)]
            internal static extern void ClipControl(OpenGL.ClipControlOrigin origin, OpenGL.ClipControlDepth depth);

            [DllImport(Gl.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal static extern void ColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha);

            [DllImport(Gl.Library, EntryPoint = "glColorMaski", ExactSpelling = true)]
            internal static extern void ColorMaski(UInt32 buf, Boolean red, Boolean green, Boolean blue, Boolean alpha);

            [DllImport(Gl.Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
            internal static extern void CompileShader(UInt32 shader);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
            internal static extern void CompressedTexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal static extern void CompressedTexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
            internal static extern void CompressedTexImage3D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
            internal static extern void CompressedTexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage1D", ExactSpelling = true)]
            internal static extern void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal static extern void CompressedTexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage2D", ExactSpelling = true)]
            internal static extern void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
            internal static extern void CompressedTexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage3D", ExactSpelling = true)]
            internal static extern void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glCopyBufferSubData", ExactSpelling = true)]
            internal static extern void CopyBufferSubData(OpenGL.BufferTarget readTarget, OpenGL.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);

            [DllImport(Gl.Library, EntryPoint = "glCopyNamedBufferSubData", ExactSpelling = true)]
            internal static extern void CopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, Int32 size);

            [DllImport(Gl.Library, EntryPoint = "glCopyImageSubData", ExactSpelling = true)]
            internal static extern void CopyImageSubData(UInt32 srcName, OpenGL.BufferTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenGL.BufferTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

            [DllImport(Gl.Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
            internal static extern void CopyTexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 border);

            [DllImport(Gl.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal static extern void CopyTexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

            [DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
            internal static extern void CopyTexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

            [DllImport(Gl.Library, EntryPoint = "glCopyTextureSubImage1D", ExactSpelling = true)]
            internal static extern void CopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

            [DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal static extern void CopyTexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glCopyTextureSubImage2D", ExactSpelling = true)]
            internal static extern void CopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
            internal static extern void CopyTexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glCopyTextureSubImage3D", ExactSpelling = true)]
            internal static extern void CopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glCreateBuffers", ExactSpelling = true)]
            internal static extern void CreateBuffers(Int32 n, UInt32[] buffers);

            [DllImport(Gl.Library, EntryPoint = "glCreateFramebuffers", ExactSpelling = true)]
            internal static extern void CreateFramebuffers(Int32 n, UInt32[] ids);

            [DllImport(Gl.Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
            internal static extern UInt32 CreateProgram();

            [DllImport(Gl.Library, EntryPoint = "glCreateProgramPipelines", ExactSpelling = true)]
            internal static extern void CreateProgramPipelines(Int32 n, UInt32[] pipelines);

            [DllImport(Gl.Library, EntryPoint = "glCreateQueries", ExactSpelling = true)]
            internal static extern void CreateQueries(OpenGL.QueryTarget target, Int32 n, UInt32[] ids);

            [DllImport(Gl.Library, EntryPoint = "glCreateRenderbuffers", ExactSpelling = true)]
            internal static extern void CreateRenderbuffers(Int32 n, UInt32[] renderbuffers);

            [DllImport(Gl.Library, EntryPoint = "glCreateSamplers", ExactSpelling = true)]
            internal static extern void CreateSamplers(Int32 n, UInt32[] samplers);

            [DllImport(Gl.Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
            internal static extern UInt32 CreateShader(OpenGL.ShaderType shaderType);

            [DllImport(Gl.Library, EntryPoint = "glCreateShaderProgramv", ExactSpelling = true)]
            internal static extern UInt32 CreateShaderProgramv(OpenGL.ShaderType type, Int32 count, String strings);

            [DllImport(Gl.Library, EntryPoint = "glCreateTextures", ExactSpelling = true)]
            internal static extern void CreateTextures(OpenGL.TextureTarget target, Int32 n, UInt32[] textures);

            [DllImport(Gl.Library, EntryPoint = "glCreateTransformFeedbacks", ExactSpelling = true)]
            internal static extern void CreateTransformFeedbacks(Int32 n, UInt32[] ids);

            [DllImport(Gl.Library, EntryPoint = "glCreateVertexArrays", ExactSpelling = true)]
            internal static extern void CreateVertexArrays(Int32 n, UInt32[] arrays);

            [DllImport(Gl.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal static extern void CullFace(OpenGL.CullFaceMode mode);

            [DllImport(Gl.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal static extern void DeleteBuffers(Int32 n, UInt32[] buffers);

            [DllImport(Gl.Library, EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
            internal static extern void DeleteFramebuffers(Int32 n, UInt32[] framebuffers);

            [DllImport(Gl.Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
            internal static extern void DeleteProgram(UInt32 program);

            [DllImport(Gl.Library, EntryPoint = "glDeleteProgramPipelines", ExactSpelling = true)]
            internal static extern void DeleteProgramPipelines(Int32 n, UInt32[] pipelines);

            [DllImport(Gl.Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
            internal static extern void DeleteQueries(Int32 n, UInt32[] ids);

            [DllImport(Gl.Library, EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
            internal static extern void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers);

            [DllImport(Gl.Library, EntryPoint = "glDeleteSamplers", ExactSpelling = true)]
            internal static extern void DeleteSamplers(Int32 n, UInt32[] samplers);

            [DllImport(Gl.Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
            internal static extern void DeleteShader(UInt32 shader);

            [DllImport(Gl.Library, EntryPoint = "glDeleteSync", ExactSpelling = true)]
            internal static extern void DeleteSync(IntPtr sync);

            [DllImport(Gl.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal static extern void DeleteTextures(Int32 n, UInt32[] textures);

            [DllImport(Gl.Library, EntryPoint = "glDeleteTransformFeedbacks", ExactSpelling = true)]
            internal static extern void DeleteTransformFeedbacks(Int32 n, UInt32[] ids);

            [DllImport(Gl.Library, EntryPoint = "glDeleteVertexArrays", ExactSpelling = true)]
            internal static extern void DeleteVertexArrays(Int32 n, UInt32[] arrays);

            [DllImport(Gl.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal static extern void DepthFunc(OpenGL.DepthFunction func);

            [DllImport(Gl.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal static extern void DepthMask(Boolean flag);

            [DllImport(Gl.Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
            internal static extern void DepthRange(Double nearVal, Double farVal);

            [DllImport(Gl.Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal static extern void DepthRangef(Single nearVal, Single farVal);

            [DllImport(Gl.Library, EntryPoint = "glDepthRangeArrayv", ExactSpelling = true)]
            internal static extern void DepthRangeArrayv(UInt32 first, Int32 count, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glDepthRangeIndexed", ExactSpelling = true)]
            internal static extern void DepthRangeIndexed(UInt32 index, Double nearVal, Double farVal);

            [DllImport(Gl.Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
            internal static extern void DetachShader(UInt32 program, UInt32 shader);

            [DllImport(Gl.Library, EntryPoint = "glDispatchCompute", ExactSpelling = true)]
            internal static extern void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);

            [DllImport(Gl.Library, EntryPoint = "glDispatchComputeIndirect", ExactSpelling = true)]
            internal static extern void DispatchComputeIndirect(IntPtr indirect);

            [DllImport(Gl.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal static extern void DrawArrays(OpenGL.BeginMode mode, Int32 first, Int32 count);

            [DllImport(Gl.Library, EntryPoint = "glDrawArraysIndirect", ExactSpelling = true)]
            internal static extern void DrawArraysIndirect(OpenGL.BeginMode mode, IntPtr indirect);

            [DllImport(Gl.Library, EntryPoint = "glDrawArraysInstanced", ExactSpelling = true)]
            internal static extern void DrawArraysInstanced(OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount);

            [DllImport(Gl.Library, EntryPoint = "glDrawArraysInstancedBaseInstance", ExactSpelling = true)]
            internal static extern void DrawArraysInstancedBaseInstance(OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount, UInt32 baseinstance);

            [DllImport(Gl.Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
            internal static extern void DrawBuffer(OpenGL.DrawBufferMode buf);

            [DllImport(Gl.Library, EntryPoint = "glNamedFramebufferDrawBuffer", ExactSpelling = true)]
            internal static extern void NamedFramebufferDrawBuffer(UInt32 framebuffer, OpenGL.DrawBufferMode buf);

            [DllImport(Gl.Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
            internal static extern void DrawBuffers(Int32 n, OpenGL.DrawBuffersEnum[] bufs);

            [DllImport(Gl.Library, EntryPoint = "glNamedFramebufferDrawBuffers", ExactSpelling = true)]
            internal static extern void NamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, OpenGL.DrawBufferMode[] bufs);

            [DllImport(Gl.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal static extern void DrawElements(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices);

            [DllImport(Gl.Library, EntryPoint = "glDrawElementsBaseVertex", ExactSpelling = true)]
            internal static extern void DrawElementsBaseVertex(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);

            [DllImport(Gl.Library, EntryPoint = "glDrawElementsIndirect", ExactSpelling = true)]
            internal static extern void DrawElementsIndirect(OpenGL.BeginMode mode, OpenGL.DrawElementsType type, IntPtr indirect);

            [DllImport(Gl.Library, EntryPoint = "glDrawElementsInstanced", ExactSpelling = true)]
            internal static extern void DrawElementsInstanced(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);

            [DllImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseInstance", ExactSpelling = true)]
            internal static extern void DrawElementsInstancedBaseInstance(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, UInt32 baseinstance);

            [DllImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseVertex", ExactSpelling = true)]
            internal static extern void DrawElementsInstancedBaseVertex(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex);

            [DllImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", ExactSpelling = true)]
            internal static extern void DrawElementsInstancedBaseVertexBaseInstance(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance);

            [DllImport(Gl.Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
            internal static extern void DrawRangeElements(OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenGL.DrawElementsType type, IntPtr indices);

            [DllImport(Gl.Library, EntryPoint = "glDrawRangeElementsBaseVertex", ExactSpelling = true)]
            internal static extern void DrawRangeElementsBaseVertex(OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);

            [DllImport(Gl.Library, EntryPoint = "glDrawTransformFeedback", ExactSpelling = true)]
            internal static extern void DrawTransformFeedback(OpenGL.NvTransformFeedback2 mode, UInt32 id);

            [DllImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackInstanced", ExactSpelling = true)]
            internal static extern void DrawTransformFeedbackInstanced(OpenGL.BeginMode mode, UInt32 id, Int32 primcount);

            [DllImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackStream", ExactSpelling = true)]
            internal static extern void DrawTransformFeedbackStream(OpenGL.NvTransformFeedback2 mode, UInt32 id, UInt32 stream);

            [DllImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackStreamInstanced", ExactSpelling = true)]
            internal static extern void DrawTransformFeedbackStreamInstanced(OpenGL.BeginMode mode, UInt32 id, UInt32 stream, Int32 primcount);

            [DllImport(Gl.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal static extern void Enable(OpenGL.EnableCap cap);

            [DllImport(Gl.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal static extern void Disable(OpenGL.EnableCap cap);

            [DllImport(Gl.Library, EntryPoint = "glEnablei", ExactSpelling = true)]
            internal static extern void Enablei(OpenGL.EnableCap cap, UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glDisablei", ExactSpelling = true)]
            internal static extern void Disablei(OpenGL.EnableCap cap, UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
            internal static extern void EnableVertexAttribArray(UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
            internal static extern void DisableVertexAttribArray(UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glEnableVertexArrayAttrib", ExactSpelling = true)]
            internal static extern void EnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glDisableVertexArrayAttrib", ExactSpelling = true)]
            internal static extern void DisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glFenceSync", ExactSpelling = true)]
            internal static extern IntPtr FenceSync(OpenGL.ArbSync condition, UInt32 flags);

            [DllImport(Gl.Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal static extern void Finish();

            [DllImport(Gl.Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal static extern void Flush();

            [DllImport(Gl.Library, EntryPoint = "glFlushMappedBufferRange", ExactSpelling = true)]
            internal static extern void FlushMappedBufferRange(OpenGL.BufferTarget target, IntPtr offset, IntPtr length);

            [DllImport(Gl.Library, EntryPoint = "glFlushMappedNamedBufferRange", ExactSpelling = true)]
            internal static extern void FlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length);

            [DllImport(Gl.Library, EntryPoint = "glFramebufferParameteri", ExactSpelling = true)]
            internal static extern void FramebufferParameteri(OpenGL.FramebufferTarget target, OpenGL.FramebufferPName pname, Int32 param);

            [DllImport(Gl.Library, EntryPoint = "glNamedFramebufferParameteri", ExactSpelling = true)]
            internal static extern void NamedFramebufferParameteri(UInt32 framebuffer, OpenGL.FramebufferPName pname, Int32 param);

            [DllImport(Gl.Library, EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
            internal static extern void FramebufferRenderbuffer(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);

            [DllImport(Gl.Library, EntryPoint = "glNamedFramebufferRenderbuffer", ExactSpelling = true)]
            internal static extern void NamedFramebufferRenderbuffer(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);

            [DllImport(Gl.Library, EntryPoint = "glFramebufferTexture", ExactSpelling = true)]
            internal static extern void FramebufferTexture(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);

            [DllImport(Gl.Library, EntryPoint = "glFramebufferTexture1D", ExactSpelling = true)]
            internal static extern void FramebufferTexture1D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);

            [DllImport(Gl.Library, EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
            internal static extern void FramebufferTexture2D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);

            [DllImport(Gl.Library, EntryPoint = "glFramebufferTexture3D", ExactSpelling = true)]
            internal static extern void FramebufferTexture3D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level, Int32 layer);

            [DllImport(Gl.Library, EntryPoint = "glNamedFramebufferTexture", ExactSpelling = true)]
            internal static extern void NamedFramebufferTexture(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);

            [DllImport(Gl.Library, EntryPoint = "glFramebufferTextureLayer", ExactSpelling = true)]
            internal static extern void FramebufferTextureLayer(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);

            [DllImport(Gl.Library, EntryPoint = "glNamedFramebufferTextureLayer", ExactSpelling = true)]
            internal static extern void NamedFramebufferTextureLayer(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);

            [DllImport(Gl.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal static extern void FrontFace(OpenGL.FrontFaceDirection mode);

            [DllImport(Gl.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal static extern void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers);

            [DllImport(Gl.Library, EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
            internal static extern void GenerateMipmap(OpenGL.GenerateMipmapTarget target);

            [DllImport(Gl.Library, EntryPoint = "glGenerateTextureMipmap", ExactSpelling = true)]
            internal static extern void GenerateTextureMipmap(UInt32 texture);

            [DllImport(Gl.Library, EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
            internal static extern void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] ids);

            [DllImport(Gl.Library, EntryPoint = "glGenProgramPipelines", ExactSpelling = true)]
            internal static extern void GenProgramPipelines(Int32 n, [OutAttribute] UInt32[] pipelines);

            [DllImport(Gl.Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
            internal static extern void GenQueries(Int32 n, [OutAttribute] UInt32[] ids);

            [DllImport(Gl.Library, EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
            internal static extern void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers);

            [DllImport(Gl.Library, EntryPoint = "glGenSamplers", ExactSpelling = true)]
            internal static extern void GenSamplers(Int32 n, [OutAttribute] UInt32[] samplers);

            [DllImport(Gl.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal static extern void GenTextures(Int32 n, [OutAttribute] UInt32[] textures);

            [DllImport(Gl.Library, EntryPoint = "glGenTransformFeedbacks", ExactSpelling = true)]
            internal static extern void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32[] ids);

            [DllImport(Gl.Library, EntryPoint = "glGenVertexArrays", ExactSpelling = true)]
            internal static extern void GenVertexArrays(Int32 n, [OutAttribute] UInt32[] arrays);

            [DllImport(Gl.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal static extern void GetBooleanv(OpenGL.GetPName pname, [OutAttribute] Boolean[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
            internal static extern void GetDoublev(OpenGL.GetPName pname, [OutAttribute] Double[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal static extern void GetFloatv(OpenGL.GetPName pname, [OutAttribute] Single[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal static extern void GetIntegerv(OpenGL.GetPName pname, [OutAttribute] Int32[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetInteger64v", ExactSpelling = true)]
            internal static extern void GetInteger64v(OpenGL.ArbSync pname, [OutAttribute] Int64[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetBooleani_v", ExactSpelling = true)]
            internal static extern void GetBooleani_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Boolean[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetIntegeri_v", ExactSpelling = true)]
            internal static extern void GetIntegeri_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Int32[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetFloati_v", ExactSpelling = true)]
            internal static extern void GetFloati_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Single[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetDoublei_v", ExactSpelling = true)]
            internal static extern void GetDoublei_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Double[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetInteger64i_v", ExactSpelling = true)]
            internal static extern void GetInteger64i_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Int64[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveAtomicCounterBufferiv", ExactSpelling = true)]
            internal static extern void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenGL.AtomicCounterParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
            internal static extern void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveAttribType[] type, [OutAttribute] System.Text.StringBuilder name);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveSubroutineName", ExactSpelling = true)]
            internal static extern void GetActiveSubroutineName(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveSubroutineUniformiv", ExactSpelling = true)]
            internal static extern void GetActiveSubroutineUniformiv(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, OpenGL.SubroutineParameterName pname, [OutAttribute] Int32[] values);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveSubroutineUniformName", ExactSpelling = true)]
            internal static extern void GetActiveSubroutineUniformName(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
            internal static extern void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveUniformType[] type, [OutAttribute] System.Text.StringBuilder name);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveUniformBlockiv", ExactSpelling = true)]
            internal static extern void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenGL.ActiveUniformBlockParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveUniformBlockName", ExactSpelling = true)]
            internal static extern void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder uniformBlockName);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveUniformName", ExactSpelling = true)]
            internal static extern void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder uniformName);

            [DllImport(Gl.Library, EntryPoint = "glGetActiveUniformsiv", ExactSpelling = true)]
            internal static extern void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, [OutAttribute] UInt32[] uniformIndices, OpenGL.ActiveUniformType pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
            internal static extern void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32[] count, [OutAttribute] UInt32[] shaders);

            [DllImport(Gl.Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
            internal static extern Int32 GetAttribLocation(UInt32 program, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal static extern void GetBufferParameteriv(OpenGL.BufferTarget target, OpenGL.BufferParameterName value, [OutAttribute] Int32[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetBufferParameteri64v", ExactSpelling = true)]
            internal static extern void GetBufferParameteri64v(OpenGL.BufferTarget target, OpenGL.BufferParameterName value, [OutAttribute] Int64[] data);

            [DllImport(Gl.Library, EntryPoint = "glGetNamedBufferParameteriv", ExactSpelling = true)]
            internal static extern void GetNamedBufferParameteriv(UInt32 buffer, OpenGL.BufferParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetNamedBufferParameteri64v", ExactSpelling = true)]
            internal static extern void GetNamedBufferParameteri64v(UInt32 buffer, OpenGL.BufferParameterName pname, [OutAttribute] Int64[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
            internal static extern void GetBufferPointerv(OpenGL.BufferTarget target, OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);

            [DllImport(Gl.Library, EntryPoint = "glGetNamedBufferPointerv", ExactSpelling = true)]
            internal static extern void GetNamedBufferPointerv(UInt32 buffer, OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);

            [DllImport(Gl.Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
            internal static extern void GetBufferSubData(OpenGL.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glGetNamedBufferSubData", ExactSpelling = true)]
            internal static extern void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, [OutAttribute] IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
            internal static extern void GetCompressedTexImage(OpenGL.TextureTarget target, Int32 level, [OutAttribute] IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glGetnCompressedTexImage", ExactSpelling = true)]
            internal static extern void GetnCompressedTexImage(OpenGL.TextureTarget target, Int32 level, Int32 bufSize, [OutAttribute] IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glGetCompressedTextureImage", ExactSpelling = true)]
            internal static extern void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, [OutAttribute] IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glGetCompressedTextureSubImage", ExactSpelling = true)]
            internal static extern void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, [OutAttribute] IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal static extern OpenGL.ErrorCode GetError();

            [DllImport(Gl.Library, EntryPoint = "glGetFragDataIndex", ExactSpelling = true)]
            internal static extern Int32 GetFragDataIndex(UInt32 program, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetFragDataLocation", ExactSpelling = true)]
            internal static extern Int32 GetFragDataLocation(UInt32 program, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
            internal static extern void GetFramebufferAttachmentParameteriv(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.FramebufferParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", ExactSpelling = true)]
            internal static extern void GetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, OpenGL.FramebufferParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetFramebufferParameteriv", ExactSpelling = true)]
            internal static extern void GetFramebufferParameteriv(OpenGL.FramebufferTarget target, OpenGL.FramebufferPName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetNamedFramebufferParameteriv", ExactSpelling = true)]
            internal static extern void GetNamedFramebufferParameteriv(UInt32 framebuffer, OpenGL.FramebufferPName pname, [OutAttribute] Int32[] param);

            [DllImport(Gl.Library, EntryPoint = "glGetGraphicsResetStatus", ExactSpelling = true)]
            internal static extern OpenGL.GraphicResetStatus GetGraphicsResetStatus();

            [DllImport(Gl.Library, EntryPoint = "glGetInternalformativ", ExactSpelling = true)]
            internal static extern void GetInternalformativ(OpenGL.TextureTarget target, OpenGL.PixelInternalFormat internalFormat, OpenGL.GetPName pname, Int32 bufSize, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetInternalformati64v", ExactSpelling = true)]
            internal static extern void GetInternalformati64v(OpenGL.TextureTarget target, OpenGL.PixelInternalFormat internalFormat, OpenGL.GetPName pname, Int32 bufSize, [OutAttribute] Int64[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetMultisamplefv", ExactSpelling = true)]
            internal static extern void GetMultisamplefv(OpenGL.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single[] val);

            [DllImport(Gl.Library, EntryPoint = "glGetObjectLabel", ExactSpelling = true)]
            internal static extern void GetObjectLabel(OpenGL.ObjectLabel identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder label);

            [DllImport(Gl.Library, EntryPoint = "glGetObjectPtrLabel", ExactSpelling = true)]
            internal static extern void GetObjectPtrLabel([OutAttribute] IntPtr ptr, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder label);

            [DllImport(Gl.Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
            internal static extern void GetPointerv(OpenGL.GetPointerParameter pname, [OutAttribute] IntPtr @params);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
            internal static extern void GetProgramiv(UInt32 program, OpenGL.ProgramParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramBinary", ExactSpelling = true)]
            internal static extern void GetProgramBinary(UInt32 program, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] binaryFormat, [OutAttribute] IntPtr binary);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
            internal static extern void GetProgramInfoLog(UInt32 program, Int32 maxLength, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramInterfaceiv", ExactSpelling = true)]
            internal static extern void GetProgramInterfaceiv(UInt32 program, OpenGL.ProgramInterface programInterface, OpenGL.ProgramInterfaceParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramPipelineiv", ExactSpelling = true)]
            internal static extern void GetProgramPipelineiv(UInt32 pipeline, Int32 pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramPipelineInfoLog", ExactSpelling = true)]
            internal static extern void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramResourceiv", ExactSpelling = true)]
            internal static extern void GetProgramResourceiv(UInt32 program, OpenGL.ProgramInterface programInterface, UInt32 index, Int32 propCount, [OutAttribute] OpenGL.ProgramResourceParameterName[] props, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramResourceIndex", ExactSpelling = true)]
            internal static extern UInt32 GetProgramResourceIndex(UInt32 program, OpenGL.ProgramInterface programInterface, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramResourceLocation", ExactSpelling = true)]
            internal static extern Int32 GetProgramResourceLocation(UInt32 program, OpenGL.ProgramInterface programInterface, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramResourceLocationIndex", ExactSpelling = true)]
            internal static extern Int32 GetProgramResourceLocationIndex(UInt32 program, OpenGL.ProgramInterface programInterface, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramResourceName", ExactSpelling = true)]
            internal static extern void GetProgramResourceName(UInt32 program, OpenGL.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);

            [DllImport(Gl.Library, EntryPoint = "glGetProgramStageiv", ExactSpelling = true)]
            internal static extern void GetProgramStageiv(UInt32 program, OpenGL.ShaderType shadertype, OpenGL.ProgramStageParameterName pname, [OutAttribute] Int32[] values);

            [DllImport(Gl.Library, EntryPoint = "glGetQueryIndexediv", ExactSpelling = true)]
            internal static extern void GetQueryIndexediv(OpenGL.QueryTarget target, UInt32 index, OpenGL.GetQueryParam pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
            internal static extern void GetQueryiv(OpenGL.QueryTarget target, OpenGL.GetQueryParam pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
            internal static extern void GetQueryObjectiv(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
            internal static extern void GetQueryObjectuiv(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetQueryObjecti64v", ExactSpelling = true)]
            internal static extern void GetQueryObjecti64v(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] Int64[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetQueryObjectui64v", ExactSpelling = true)]
            internal static extern void GetQueryObjectui64v(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt64[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
            internal static extern void GetRenderbufferParameteriv(OpenGL.RenderbufferTarget target, OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetNamedRenderbufferParameteriv", ExactSpelling = true)]
            internal static extern void GetNamedRenderbufferParameteriv(UInt32 renderbuffer, OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetSamplerParameterfv", ExactSpelling = true)]
            internal static extern void GetSamplerParameterfv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetSamplerParameteriv", ExactSpelling = true)]
            internal static extern void GetSamplerParameteriv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetSamplerParameterIiv", ExactSpelling = true)]
            internal static extern void GetSamplerParameterIiv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetSamplerParameterIuiv", ExactSpelling = true)]
            internal static extern void GetSamplerParameterIuiv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
            internal static extern void GetShaderiv(UInt32 shader, OpenGL.ShaderParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
            internal static extern void GetShaderInfoLog(UInt32 shader, Int32 maxLength, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);

            [DllImport(Gl.Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
            internal static extern void GetShaderPrecisionFormat(OpenGL.ShaderType shaderType, Int32 precisionType, [OutAttribute] Int32[] range, [OutAttribute] Int32[] precision);

            [DllImport(Gl.Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
            internal static extern void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder source);

            [DllImport(Gl.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal static extern IntPtr GetString(OpenGL.StringName name);

            [DllImport(Gl.Library, EntryPoint = "glGetStringi", ExactSpelling = true)]
            internal static extern IntPtr GetStringi(OpenGL.StringName name, UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glGetSubroutineIndex", ExactSpelling = true)]
            internal static extern UInt32 GetSubroutineIndex(UInt32 program, OpenGL.ShaderType shadertype, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetSubroutineUniformLocation", ExactSpelling = true)]
            internal static extern Int32 GetSubroutineUniformLocation(UInt32 program, OpenGL.ShaderType shadertype, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetSynciv", ExactSpelling = true)]
            internal static extern void GetSynciv(IntPtr sync, OpenGL.ArbSync pname, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] values);

            [DllImport(Gl.Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
            internal static extern void GetTexImage(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, [OutAttribute] IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glGetnTexImage", ExactSpelling = true)]
            internal static extern void GetnTexImage(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glGetTextureImage", ExactSpelling = true)]
            internal static extern void GetTextureImage(UInt32 texture, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
            internal static extern void GetTexLevelParameterfv(OpenGL.GetPName target, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
            internal static extern void GetTexLevelParameteriv(OpenGL.GetPName target, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTextureLevelParameterfv", ExactSpelling = true)]
            internal static extern void GetTextureLevelParameterfv(UInt32 texture, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTextureLevelParameteriv", ExactSpelling = true)]
            internal static extern void GetTextureLevelParameteriv(UInt32 texture, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal static extern void GetTexParameterfv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal static extern void GetTexParameteriv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTexParameterIiv", ExactSpelling = true)]
            internal static extern void GetTexParameterIiv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTexParameterIuiv", ExactSpelling = true)]
            internal static extern void GetTexParameterIuiv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTextureParameterfv", ExactSpelling = true)]
            internal static extern void GetTextureParameterfv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTextureParameteriv", ExactSpelling = true)]
            internal static extern void GetTextureParameteriv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTextureParameterIiv", ExactSpelling = true)]
            internal static extern void GetTextureParameterIiv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTextureParameterIuiv", ExactSpelling = true)]
            internal static extern void GetTextureParameterIuiv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetTextureSubImage", ExactSpelling = true)]
            internal static extern void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbackiv", ExactSpelling = true)]
            internal static extern void GetTransformFeedbackiv(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, [OutAttribute] Int32[] param);

            [DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbacki_v", ExactSpelling = true)]
            internal static extern void GetTransformFeedbacki_v(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, UInt32 index, [OutAttribute] Int32[] param);

            [DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbacki64_v", ExactSpelling = true)]
            internal static extern void GetTransformFeedbacki64_v(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, UInt32 index, [OutAttribute] Int64[] param);

            [DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbackVarying", ExactSpelling = true)]
            internal static extern void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveAttribType[] type, [OutAttribute] System.Text.StringBuilder name);

            [DllImport(Gl.Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
            internal static extern void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
            internal static extern void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetUniformuiv", ExactSpelling = true)]
            internal static extern void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetUniformdv", ExactSpelling = true)]
            internal static extern void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetnUniformfv", ExactSpelling = true)]
            internal static extern void GetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetnUniformiv", ExactSpelling = true)]
            internal static extern void GetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetnUniformuiv", ExactSpelling = true)]
            internal static extern void GetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetnUniformdv", ExactSpelling = true)]
            internal static extern void GetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetUniformBlockIndex", ExactSpelling = true)]
            internal static extern UInt32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);

            [DllImport(Gl.Library, EntryPoint = "glGetUniformIndices", ExactSpelling = true)]
            internal static extern void GetUniformIndices(UInt32 program, Int32 uniformCount, String uniformNames, [OutAttribute] UInt32[] uniformIndices);

            [DllImport(Gl.Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
            internal static extern Int32 GetUniformLocation(UInt32 program, String name);

            [DllImport(Gl.Library, EntryPoint = "glGetUniformSubroutineuiv", ExactSpelling = true)]
            internal static extern void GetUniformSubroutineuiv(OpenGL.ShaderType shadertype, Int32 location, [OutAttribute] UInt32[] values);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexArrayIndexed64iv", ExactSpelling = true)]
            internal static extern void GetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int64[] param);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexArrayIndexediv", ExactSpelling = true)]
            internal static extern void GetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] param);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexArrayiv", ExactSpelling = true)]
            internal static extern void GetVertexArrayiv(UInt32 vaobj, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] param);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
            internal static extern void GetVertexAttribdv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Double[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
            internal static extern void GetVertexAttribfv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
            internal static extern void GetVertexAttribiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexAttribIiv", ExactSpelling = true)]
            internal static extern void GetVertexAttribIiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexAttribIuiv", ExactSpelling = true)]
            internal static extern void GetVertexAttribIuiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexAttribLdv", ExactSpelling = true)]
            internal static extern void GetVertexAttribLdv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Double[] @params);

            [DllImport(Gl.Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
            internal static extern void GetVertexAttribPointerv(UInt32 index, OpenGL.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);

            [DllImport(Gl.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal static extern void Hint(OpenGL.HintTarget target, OpenGL.HintMode mode);

            [DllImport(Gl.Library, EntryPoint = "glInvalidateBufferData", ExactSpelling = true)]
            internal static extern void InvalidateBufferData(UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glInvalidateBufferSubData", ExactSpelling = true)]
            internal static extern void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);

            [DllImport(Gl.Library, EntryPoint = "glInvalidateFramebuffer", ExactSpelling = true)]
            internal static extern void InvalidateFramebuffer(OpenGL.FramebufferTarget target, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments);

            [DllImport(Gl.Library, EntryPoint = "glInvalidateNamedFramebufferData", ExactSpelling = true)]
            internal static extern void InvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments);

            [DllImport(Gl.Library, EntryPoint = "glInvalidateSubFramebuffer", ExactSpelling = true)]
            internal static extern void InvalidateSubFramebuffer(OpenGL.FramebufferTarget target, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glInvalidateNamedFramebufferSubData", ExactSpelling = true)]
            internal static extern void InvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glInvalidateTexImage", ExactSpelling = true)]
            internal static extern void InvalidateTexImage(UInt32 texture, Int32 level);

            [DllImport(Gl.Library, EntryPoint = "glInvalidateTexSubImage", ExactSpelling = true)]
            internal static extern void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);

            [DllImport(Gl.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal static extern Boolean IsBuffer(UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal static extern Boolean IsEnabled(OpenGL.EnableCap cap);

            [DllImport(Gl.Library, EntryPoint = "glIsEnabledi", ExactSpelling = true)]
            internal static extern Boolean IsEnabledi(OpenGL.EnableCap cap, UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
            internal static extern Boolean IsFramebuffer(UInt32 framebuffer);

            [DllImport(Gl.Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
            internal static extern Boolean IsProgram(UInt32 program);

            [DllImport(Gl.Library, EntryPoint = "glIsProgramPipeline", ExactSpelling = true)]
            internal static extern Boolean IsProgramPipeline(UInt32 pipeline);

            [DllImport(Gl.Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
            internal static extern Boolean IsQuery(UInt32 id);

            [DllImport(Gl.Library, EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
            internal static extern Boolean IsRenderbuffer(UInt32 renderbuffer);

            [DllImport(Gl.Library, EntryPoint = "glIsSampler", ExactSpelling = true)]
            internal static extern Boolean IsSampler(UInt32 id);

            [DllImport(Gl.Library, EntryPoint = "glIsShader", ExactSpelling = true)]
            internal static extern Boolean IsShader(UInt32 shader);

            [DllImport(Gl.Library, EntryPoint = "glIsSync", ExactSpelling = true)]
            internal static extern Boolean IsSync(IntPtr sync);

            [DllImport(Gl.Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
            internal static extern Boolean IsTexture(UInt32 texture);

            [DllImport(Gl.Library, EntryPoint = "glIsTransformFeedback", ExactSpelling = true)]
            internal static extern Boolean IsTransformFeedback(UInt32 id);

            [DllImport(Gl.Library, EntryPoint = "glIsVertexArray", ExactSpelling = true)]
            internal static extern Boolean IsVertexArray(UInt32 array);

            [DllImport(Gl.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal static extern void LineWidth(Single width);

            [DllImport(Gl.Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
            internal static extern void LinkProgram(UInt32 program);

            [DllImport(Gl.Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal static extern void LogicOp(OpenGL.LogicOp opcode);

            [DllImport(Gl.Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
            internal static extern IntPtr MapBuffer(OpenGL.BufferTarget target, OpenGL.BufferAccess access);

            [DllImport(Gl.Library, EntryPoint = "glMapNamedBuffer", ExactSpelling = true)]
            internal static extern IntPtr MapNamedBuffer(UInt32 buffer, OpenGL.BufferAccess access);

            [DllImport(Gl.Library, EntryPoint = "glMapBufferRange", ExactSpelling = true)]
            internal static extern IntPtr MapBufferRange(OpenGL.BufferTarget target, IntPtr offset, IntPtr length, OpenGL.BufferAccessMask access);

            [DllImport(Gl.Library, EntryPoint = "glMapNamedBufferRange", ExactSpelling = true)]
            internal static extern IntPtr MapNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length, UInt32 access);

            [DllImport(Gl.Library, EntryPoint = "glMemoryBarrier", ExactSpelling = true)]
            internal static extern void MemoryBarrier(UInt32 barriers);

            [DllImport(Gl.Library, EntryPoint = "glMemoryBarrierByRegion", ExactSpelling = true)]
            internal static extern void MemoryBarrierByRegion(UInt32 barriers);

            [DllImport(Gl.Library, EntryPoint = "glMinSampleShading", ExactSpelling = true)]
            internal static extern void MinSampleShading(Single value);

            [DllImport(Gl.Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
            internal static extern void MultiDrawArrays(OpenGL.BeginMode mode, Int32[] first, Int32[] count, Int32 drawcount);

            [DllImport(Gl.Library, EntryPoint = "glMultiDrawArraysIndirect", ExactSpelling = true)]
            internal static extern void MultiDrawArraysIndirect(OpenGL.BeginMode mode, IntPtr indirect, Int32 drawcount, Int32 stride);

            [DllImport(Gl.Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
            internal static extern void MultiDrawElements(OpenGL.BeginMode mode, Int32[] count, OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount);

            [DllImport(Gl.Library, EntryPoint = "glMultiDrawElementsBaseVertex", ExactSpelling = true)]
            internal static extern void MultiDrawElementsBaseVertex(OpenGL.BeginMode mode, Int32[] count, OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32[] basevertex);

            [DllImport(Gl.Library, EntryPoint = "glMultiDrawElementsIndirect", ExactSpelling = true)]
            internal static extern void MultiDrawElementsIndirect(OpenGL.BeginMode mode, OpenGL.DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride);

            [DllImport(Gl.Library, EntryPoint = "glObjectLabel", ExactSpelling = true)]
            internal static extern void ObjectLabel(OpenGL.ObjectLabel identifier, UInt32 name, Int32 length, String label);

            [DllImport(Gl.Library, EntryPoint = "glObjectPtrLabel", ExactSpelling = true)]
            internal static extern void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);

            [DllImport(Gl.Library, EntryPoint = "glPatchParameteri", ExactSpelling = true)]
            internal static extern void PatchParameteri(Int32 pname, Int32 value);

            [DllImport(Gl.Library, EntryPoint = "glPatchParameterfv", ExactSpelling = true)]
            internal static extern void PatchParameterfv(Int32 pname, Single[] values);

            [DllImport(Gl.Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
            internal static extern void PixelStoref(OpenGL.PixelStoreParameter pname, Single param);

            [DllImport(Gl.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal static extern void PixelStorei(OpenGL.PixelStoreParameter pname, Int32 param);

            [DllImport(Gl.Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
            internal static extern void PointParameterf(OpenGL.PointParameterName pname, Single param);

            [DllImport(Gl.Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
            internal static extern void PointParameteri(OpenGL.PointParameterName pname, Int32 param);

            [DllImport(Gl.Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
            internal static extern void PointParameterfv(OpenGL.PointParameterName pname, Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
            internal static extern void PointParameteriv(OpenGL.PointParameterName pname, Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal static extern void PointSize(Single size);

            [DllImport(Gl.Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
            internal static extern void PolygonMode(OpenGL.MaterialFace face, OpenGL.PolygonMode mode);

            [DllImport(Gl.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal static extern void PolygonOffset(Single factor, Single units);

            [DllImport(Gl.Library, EntryPoint = "glPrimitiveRestartIndex", ExactSpelling = true)]
            internal static extern void PrimitiveRestartIndex(UInt32 index);

            [DllImport(Gl.Library, EntryPoint = "glProgramBinary", ExactSpelling = true)]
            internal static extern void ProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);

            [DllImport(Gl.Library, EntryPoint = "glProgramParameteri", ExactSpelling = true)]
            internal static extern void ProgramParameteri(UInt32 program, OpenGL.Version32 pname, Int32 value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform1f", ExactSpelling = true)]
            internal static extern void ProgramUniform1f(UInt32 program, Int32 location, Single v0);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform2f", ExactSpelling = true)]
            internal static extern void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform3f", ExactSpelling = true)]
            internal static extern void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform4f", ExactSpelling = true)]
            internal static extern void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform1i", ExactSpelling = true)]
            internal static extern void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform2i", ExactSpelling = true)]
            internal static extern void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform3i", ExactSpelling = true)]
            internal static extern void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform4i", ExactSpelling = true)]
            internal static extern void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform1ui", ExactSpelling = true)]
            internal static extern void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform2ui", ExactSpelling = true)]
            internal static extern void ProgramUniform2ui(UInt32 program, Int32 location, Int32 v0, UInt32 v1);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform3ui", ExactSpelling = true)]
            internal static extern void ProgramUniform3ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, UInt32 v2);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform4ui", ExactSpelling = true)]
            internal static extern void ProgramUniform4ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, UInt32 v3);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform1fv", ExactSpelling = true)]
            internal static extern void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform2fv", ExactSpelling = true)]
            internal static extern void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform3fv", ExactSpelling = true)]
            internal static extern void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform4fv", ExactSpelling = true)]
            internal static extern void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform1iv", ExactSpelling = true)]
            internal static extern void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform2iv", ExactSpelling = true)]
            internal static extern void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform3iv", ExactSpelling = true)]
            internal static extern void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform4iv", ExactSpelling = true)]
            internal static extern void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform1uiv", ExactSpelling = true)]
            internal static extern void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform2uiv", ExactSpelling = true)]
            internal static extern void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform3uiv", ExactSpelling = true)]
            internal static extern void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniform4uiv", ExactSpelling = true)]
            internal static extern void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2x3fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3x2fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2x4fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4x2fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3x4fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4x3fv", ExactSpelling = true)]
            internal static extern void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glProvokingVertex", ExactSpelling = true)]
            internal static extern void ProvokingVertex(OpenGL.ProvokingVertexMode provokeMode);

            [DllImport(Gl.Library, EntryPoint = "glQueryCounter", ExactSpelling = true)]
            internal static extern void QueryCounter(UInt32 id, OpenGL.QueryTarget target);

            [DllImport(Gl.Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
            internal static extern void ReadBuffer(OpenGL.ReadBufferMode mode);

            [DllImport(Gl.Library, EntryPoint = "glNamedFramebufferReadBuffer", ExactSpelling = true)]
            internal static extern void NamedFramebufferReadBuffer(OpenGL.ReadBufferMode framebuffer, OpenGL.BeginMode mode);

            [DllImport(Gl.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal static extern void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32[] data);

            [DllImport(Gl.Library, EntryPoint = "glReadnPixels", ExactSpelling = true)]
            internal static extern void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, Int32[] data);

            [DllImport(Gl.Library, EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
            internal static extern void RenderbufferStorage(OpenGL.RenderbufferTarget target, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glNamedRenderbufferStorage", ExactSpelling = true)]
            internal static extern void NamedRenderbufferStorage(UInt32 renderbuffer, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glRenderbufferStorageMultisample", ExactSpelling = true)]
            internal static extern void RenderbufferStorageMultisample(OpenGL.RenderbufferTarget target, Int32 samples, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glNamedRenderbufferStorageMultisample", ExactSpelling = true)]
            internal static extern void NamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal static extern void SampleCoverage(Single value, Boolean invert);

            [DllImport(Gl.Library, EntryPoint = "glSampleMaski", ExactSpelling = true)]
            internal static extern void SampleMaski(UInt32 maskNumber, UInt32 mask);

            [DllImport(Gl.Library, EntryPoint = "glSamplerParameterf", ExactSpelling = true)]
            internal static extern void SamplerParameterf(UInt32 sampler, OpenGL.TextureParameterName pname, Single param);

            [DllImport(Gl.Library, EntryPoint = "glSamplerParameteri", ExactSpelling = true)]
            internal static extern void SamplerParameteri(UInt32 sampler, OpenGL.TextureParameterName pname, Int32 param);

            [DllImport(Gl.Library, EntryPoint = "glSamplerParameterfv", ExactSpelling = true)]
            internal static extern void SamplerParameterfv(UInt32 sampler, OpenGL.TextureParameterName pname, Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glSamplerParameteriv", ExactSpelling = true)]
            internal static extern void SamplerParameteriv(UInt32 sampler, OpenGL.TextureParameterName pname, Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glSamplerParameterIiv", ExactSpelling = true)]
            internal static extern void SamplerParameterIiv(UInt32 sampler, OpenGL.TextureParameterName pname, Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glSamplerParameterIuiv", ExactSpelling = true)]
            internal static extern void SamplerParameterIuiv(UInt32 sampler, OpenGL.TextureParameterName pname, UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal static extern void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glScissorArrayv", ExactSpelling = true)]
            internal static extern void ScissorArrayv(UInt32 first, Int32 count, Int32[] v);

            [DllImport(Gl.Library, EntryPoint = "glScissorIndexed", ExactSpelling = true)]
            internal static extern void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glScissorIndexedv", ExactSpelling = true)]
            internal static extern void ScissorIndexedv(UInt32 index, Int32[] v);

            [DllImport(Gl.Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
            internal static extern void ShaderBinary(Int32 count, UInt32[] shaders, Int32 binaryFormat, IntPtr binary, Int32 length);

            [DllImport(Gl.Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
            internal static extern void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length);

            [DllImport(Gl.Library, EntryPoint = "glShaderStorageBlockBinding", ExactSpelling = true)]
            internal static extern void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);

            [DllImport(Gl.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal static extern void StencilFunc(OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);

            [DllImport(Gl.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal static extern void StencilFuncSeparate(OpenGL.StencilFace face, OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);

            [DllImport(Gl.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal static extern void StencilMask(UInt32 mask);

            [DllImport(Gl.Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
            internal static extern void StencilMaskSeparate(OpenGL.StencilFace face, UInt32 mask);

            [DllImport(Gl.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal static extern void StencilOp(OpenGL.StencilOp sfail, OpenGL.StencilOp dpfail, OpenGL.StencilOp dppass);

            [DllImport(Gl.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal static extern void StencilOpSeparate(OpenGL.StencilFace face, OpenGL.StencilOp sfail, OpenGL.StencilOp dpfail, OpenGL.StencilOp dppass);

            [DllImport(Gl.Library, EntryPoint = "glTexBuffer", ExactSpelling = true)]
            internal static extern void TexBuffer(OpenGL.TextureBufferTarget target, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glTextureBuffer", ExactSpelling = true)]
            internal static extern void TextureBuffer(UInt32 texture, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glTexBufferRange", ExactSpelling = true)]
            internal static extern void TexBufferRange(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, IntPtr size);

            [DllImport(Gl.Library, EntryPoint = "glTextureBufferRange", ExactSpelling = true)]
            internal static extern void TextureBufferRange(UInt32 texture, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, Int32 size);

            [DllImport(Gl.Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
            internal static extern void TexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal static extern void TexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glTexImage2DMultisample", ExactSpelling = true)]
            internal static extern void TexImage2DMultisample(OpenGL.TextureTargetMultisample target, Int32 samples, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);

            [DllImport(Gl.Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
            internal static extern void TexImage3D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);

            [DllImport(Gl.Library, EntryPoint = "glTexImage3DMultisample", ExactSpelling = true)]
            internal static extern void TexImage3DMultisample(OpenGL.TextureTargetMultisample target, Int32 samples, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);

            [DllImport(Gl.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal static extern void TexParameterf(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Single param);

            [DllImport(Gl.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal static extern void TexParameteri(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32 param);

            [DllImport(Gl.Library, EntryPoint = "glTextureParameterf", ExactSpelling = true)]
            internal static extern void TextureParameterf(UInt32 texture, OpenGL.TextureParameter pname, Single param);

            [DllImport(Gl.Library, EntryPoint = "glTextureParameteri", ExactSpelling = true)]
            internal static extern void TextureParameteri(UInt32 texture, OpenGL.TextureParameter pname, Int32 param);

            [DllImport(Gl.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal static extern void TexParameterfv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Single[] @params);

            [DllImport(Gl.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal static extern void TexParameteriv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glTexParameterIiv", ExactSpelling = true)]
            internal static extern void TexParameterIiv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glTexParameterIuiv", ExactSpelling = true)]
            internal static extern void TexParameterIuiv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glTextureParameterfv", ExactSpelling = true)]
            internal static extern void TextureParameterfv(UInt32 texture, OpenGL.TextureParameter pname, Single[] paramtexture);

            [DllImport(Gl.Library, EntryPoint = "glTextureParameteriv", ExactSpelling = true)]
            internal static extern void TextureParameteriv(UInt32 texture, OpenGL.TextureParameter pname, Int32[] param);

            [DllImport(Gl.Library, EntryPoint = "glTextureParameterIiv", ExactSpelling = true)]
            internal static extern void TextureParameterIiv(UInt32 texture, OpenGL.TextureParameter pname, Int32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glTextureParameterIuiv", ExactSpelling = true)]
            internal static extern void TextureParameterIuiv(UInt32 texture, OpenGL.TextureParameter pname, UInt32[] @params);

            [DllImport(Gl.Library, EntryPoint = "glTexStorage1D", ExactSpelling = true)]
            internal static extern void TexStorage1D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width);

            [DllImport(Gl.Library, EntryPoint = "glTextureStorage1D", ExactSpelling = true)]
            internal static extern void TextureStorage1D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width);

            [DllImport(Gl.Library, EntryPoint = "glTexStorage2D", ExactSpelling = true)]
            internal static extern void TexStorage2D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glTextureStorage2D", ExactSpelling = true)]
            internal static extern void TextureStorage2D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glTexStorage2DMultisample", ExactSpelling = true)]
            internal static extern void TexStorage2DMultisample(OpenGL.TextureTarget target, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);

            [DllImport(Gl.Library, EntryPoint = "glTextureStorage2DMultisample", ExactSpelling = true)]
            internal static extern void TextureStorage2DMultisample(UInt32 texture, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);

            [DllImport(Gl.Library, EntryPoint = "glTexStorage3D", ExactSpelling = true)]
            internal static extern void TexStorage3D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);

            [DllImport(Gl.Library, EntryPoint = "glTextureStorage3D", ExactSpelling = true)]
            internal static extern void TextureStorage3D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);

            [DllImport(Gl.Library, EntryPoint = "glTexStorage3DMultisample", ExactSpelling = true)]
            internal static extern void TexStorage3DMultisample(OpenGL.TextureTarget target, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);

            [DllImport(Gl.Library, EntryPoint = "glTextureStorage3DMultisample", ExactSpelling = true)]
            internal static extern void TextureStorage3DMultisample(UInt32 texture, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);

            [DllImport(Gl.Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
            internal static extern void TexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glTextureSubImage1D", ExactSpelling = true)]
            internal static extern void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal static extern void TexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glTextureSubImage2D", ExactSpelling = true)]
            internal static extern void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
            internal static extern void TexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glTextureSubImage3D", ExactSpelling = true)]
            internal static extern void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            [DllImport(Gl.Library, EntryPoint = "glTextureBarrier", ExactSpelling = true)]
            internal static extern void TextureBarrier();

            [DllImport(Gl.Library, EntryPoint = "glTextureView", ExactSpelling = true)]
            internal static extern void TextureView(UInt32 texture, OpenGL.TextureTarget target, UInt32 origtexture, OpenGL.PixelInternalFormat internalFormat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);

            [DllImport(Gl.Library, EntryPoint = "glTransformFeedbackBufferBase", ExactSpelling = true)]
            internal static extern void TransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glTransformFeedbackBufferRange", ExactSpelling = true)]
            internal static extern void TransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, Int32 size);

            [DllImport(Gl.Library, EntryPoint = "glTransformFeedbackVaryings", ExactSpelling = true)]
            internal static extern void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenGL.TransformFeedbackMode bufferMode);

            [DllImport(Gl.Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
            internal static extern void Uniform1f(Int32 location, Single v0);

            [DllImport(Gl.Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
            internal static extern void Uniform2f(Int32 location, Single v0, Single v1);

            [DllImport(Gl.Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
            internal static extern void Uniform3f(Int32 location, Single v0, Single v1, Single v2);

            [DllImport(Gl.Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
            internal static extern void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);

            [DllImport(Gl.Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
            internal static extern void Uniform1i(Int32 location, Int32 v0);

            [DllImport(Gl.Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
            internal static extern void Uniform2i(Int32 location, Int32 v0, Int32 v1);

            [DllImport(Gl.Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
            internal static extern void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);

            [DllImport(Gl.Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
            internal static extern void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

            [DllImport(Gl.Library, EntryPoint = "glUniform1ui", ExactSpelling = true)]
            internal static extern void Uniform1ui(Int32 location, UInt32 v0);

            [DllImport(Gl.Library, EntryPoint = "glUniform2ui", ExactSpelling = true)]
            internal static extern void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);

            [DllImport(Gl.Library, EntryPoint = "glUniform3ui", ExactSpelling = true)]
            internal static extern void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

            [DllImport(Gl.Library, EntryPoint = "glUniform4ui", ExactSpelling = true)]
            internal static extern void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

            [DllImport(Gl.Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
            internal static extern void Uniform1fv(Int32 location, Int32 count, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
            internal static extern void Uniform2fv(Int32 location, Int32 count, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
            internal static extern void Uniform3fv(Int32 location, Int32 count, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
            internal static extern void Uniform4fv(Int32 location, Int32 count, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
            internal static extern void Uniform1iv(Int32 location, Int32 count, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
            internal static extern void Uniform2iv(Int32 location, Int32 count, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
            internal static extern void Uniform3iv(Int32 location, Int32 count, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
            internal static extern void Uniform4iv(Int32 location, Int32 count, Int32[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform1uiv", ExactSpelling = true)]
            internal static extern void Uniform1uiv(Int32 location, Int32 count, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform2uiv", ExactSpelling = true)]
            internal static extern void Uniform2uiv(Int32 location, Int32 count, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform3uiv", ExactSpelling = true)]
            internal static extern void Uniform3uiv(Int32 location, Int32 count, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniform4uiv", ExactSpelling = true)]
            internal static extern void Uniform4uiv(Int32 location, Int32 count, UInt32[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
            internal static extern void UniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
            internal static extern void UniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
            internal static extern void UniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
            internal static extern void UniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
            internal static extern void UniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
            internal static extern void UniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
            internal static extern void UniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
            internal static extern void UniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
            internal static extern void UniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            [DllImport(Gl.Library, EntryPoint = "glUniformBlockBinding", ExactSpelling = true)]
            internal static extern void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);

            [DllImport(Gl.Library, EntryPoint = "glUniformSubroutinesuiv", ExactSpelling = true)]
            internal static extern void UniformSubroutinesuiv(OpenGL.ShaderType shadertype, Int32 count, UInt32[] indices);

            [DllImport(Gl.Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
            internal static extern Boolean UnmapBuffer(OpenGL.BufferTarget target);

            [DllImport(Gl.Library, EntryPoint = "glUnmapNamedBuffer", ExactSpelling = true)]
            internal static extern Boolean UnmapNamedBuffer(UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
            internal static extern void UseProgram(UInt32 program);

            [DllImport(Gl.Library, EntryPoint = "glUseProgramStages", ExactSpelling = true)]
            internal static extern void UseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);

            [DllImport(Gl.Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
            internal static extern void ValidateProgram(UInt32 program);

            [DllImport(Gl.Library, EntryPoint = "glValidateProgramPipeline", ExactSpelling = true)]
            internal static extern void ValidateProgramPipeline(UInt32 pipeline);

            [DllImport(Gl.Library, EntryPoint = "glVertexArrayElementBuffer", ExactSpelling = true)]
            internal static extern void VertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
            internal static extern void VertexAttrib1f(UInt32 index, Single v0);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
            internal static extern void VertexAttrib1s(UInt32 index, Int16 v0);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
            internal static extern void VertexAttrib1d(UInt32 index, Double v0);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI1i", ExactSpelling = true)]
            internal static extern void VertexAttribI1i(UInt32 index, Int32 v0);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI1ui", ExactSpelling = true)]
            internal static extern void VertexAttribI1ui(UInt32 index, UInt32 v0);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
            internal static extern void VertexAttrib2f(UInt32 index, Single v0, Single v1);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
            internal static extern void VertexAttrib2s(UInt32 index, Int16 v0, Int16 v1);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
            internal static extern void VertexAttrib2d(UInt32 index, Double v0, Double v1);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI2i", ExactSpelling = true)]
            internal static extern void VertexAttribI2i(UInt32 index, Int32 v0, Int32 v1);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI2ui", ExactSpelling = true)]
            internal static extern void VertexAttribI2ui(UInt32 index, UInt32 v0, UInt32 v1);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
            internal static extern void VertexAttrib3f(UInt32 index, Single v0, Single v1, Single v2);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
            internal static extern void VertexAttrib3s(UInt32 index, Int16 v0, Int16 v1, Int16 v2);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
            internal static extern void VertexAttrib3d(UInt32 index, Double v0, Double v1, Double v2);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI3i", ExactSpelling = true)]
            internal static extern void VertexAttribI3i(UInt32 index, Int32 v0, Int32 v1, Int32 v2);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI3ui", ExactSpelling = true)]
            internal static extern void VertexAttribI3ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
            internal static extern void VertexAttrib4f(UInt32 index, Single v0, Single v1, Single v2, Single v3);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
            internal static extern void VertexAttrib4s(UInt32 index, Int16 v0, Int16 v1, Int16 v2, Int16 v3);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
            internal static extern void VertexAttrib4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
            internal static extern void VertexAttrib4Nub(UInt32 index, Byte v0, Byte v1, Byte v2, Byte v3);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI4i", ExactSpelling = true)]
            internal static extern void VertexAttribI4i(UInt32 index, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI4ui", ExactSpelling = true)]
            internal static extern void VertexAttribI4ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribL1d", ExactSpelling = true)]
            internal static extern void VertexAttribL1d(UInt32 index, Double v0);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribL2d", ExactSpelling = true)]
            internal static extern void VertexAttribL2d(UInt32 index, Double v0, Double v1);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribL3d", ExactSpelling = true)]
            internal static extern void VertexAttribL3d(UInt32 index, Double v0, Double v1, Double v2);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribL4d", ExactSpelling = true)]
            internal static extern void VertexAttribL4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
            internal static extern void VertexAttrib1fv(UInt32 index, Single[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
            internal static extern void VertexAttrib1sv(UInt32 index, Int16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
            internal static extern void VertexAttrib1dv(UInt32 index, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI1iv", ExactSpelling = true)]
            internal static extern void VertexAttribI1iv(UInt32 index, Int32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI1uiv", ExactSpelling = true)]
            internal static extern void VertexAttribI1uiv(UInt32 index, UInt32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
            internal static extern void VertexAttrib2fv(UInt32 index, Single[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
            internal static extern void VertexAttrib2sv(UInt32 index, Int16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
            internal static extern void VertexAttrib2dv(UInt32 index, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI2iv", ExactSpelling = true)]
            internal static extern void VertexAttribI2iv(UInt32 index, Int32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI2uiv", ExactSpelling = true)]
            internal static extern void VertexAttribI2uiv(UInt32 index, UInt32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
            internal static extern void VertexAttrib3fv(UInt32 index, Single[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
            internal static extern void VertexAttrib3sv(UInt32 index, Int16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
            internal static extern void VertexAttrib3dv(UInt32 index, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI3iv", ExactSpelling = true)]
            internal static extern void VertexAttribI3iv(UInt32 index, Int32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI3uiv", ExactSpelling = true)]
            internal static extern void VertexAttribI3uiv(UInt32 index, UInt32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
            internal static extern void VertexAttrib4fv(UInt32 index, Single[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
            internal static extern void VertexAttrib4sv(UInt32 index, Int16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
            internal static extern void VertexAttrib4dv(UInt32 index, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
            internal static extern void VertexAttrib4iv(UInt32 index, Int32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
            internal static extern void VertexAttrib4bv(UInt32 index, SByte[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
            internal static extern void VertexAttrib4ubv(UInt32 index, Byte[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
            internal static extern void VertexAttrib4usv(UInt32 index, UInt16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
            internal static extern void VertexAttrib4uiv(UInt32 index, UInt32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
            internal static extern void VertexAttrib4Nbv(UInt32 index, SByte[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
            internal static extern void VertexAttrib4Nsv(UInt32 index, Int16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
            internal static extern void VertexAttrib4Niv(UInt32 index, Int32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
            internal static extern void VertexAttrib4Nubv(UInt32 index, Byte[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
            internal static extern void VertexAttrib4Nusv(UInt32 index, UInt16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
            internal static extern void VertexAttrib4Nuiv(UInt32 index, UInt32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI4bv", ExactSpelling = true)]
            internal static extern void VertexAttribI4bv(UInt32 index, SByte[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI4ubv", ExactSpelling = true)]
            internal static extern void VertexAttribI4ubv(UInt32 index, Byte[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI4sv", ExactSpelling = true)]
            internal static extern void VertexAttribI4sv(UInt32 index, Int16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI4usv", ExactSpelling = true)]
            internal static extern void VertexAttribI4usv(UInt32 index, UInt16[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI4iv", ExactSpelling = true)]
            internal static extern void VertexAttribI4iv(UInt32 index, Int32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribI4uiv", ExactSpelling = true)]
            internal static extern void VertexAttribI4uiv(UInt32 index, UInt32[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribL1dv", ExactSpelling = true)]
            internal static extern void VertexAttribL1dv(UInt32 index, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribL2dv", ExactSpelling = true)]
            internal static extern void VertexAttribL2dv(UInt32 index, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribL3dv", ExactSpelling = true)]
            internal static extern void VertexAttribL3dv(UInt32 index, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribL4dv", ExactSpelling = true)]
            internal static extern void VertexAttribL4dv(UInt32 index, Double[] v);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribP1ui", ExactSpelling = true)]
            internal static extern void VertexAttribP1ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribP2ui", ExactSpelling = true)]
            internal static extern void VertexAttribP2ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribP3ui", ExactSpelling = true)]
            internal static extern void VertexAttribP3ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribP4ui", ExactSpelling = true)]
            internal static extern void VertexAttribP4ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribBinding", ExactSpelling = true)]
            internal static extern void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);

            [DllImport(Gl.Library, EntryPoint = "glVertexArrayAttribBinding", ExactSpelling = true)]
            internal static extern void VertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribDivisor", ExactSpelling = true)]
            internal static extern void VertexAttribDivisor(UInt32 index, UInt32 divisor);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribFormat", ExactSpelling = true)]
            internal static extern void VertexAttribFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribIFormat", ExactSpelling = true)]
            internal static extern void VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribLFormat", ExactSpelling = true)]
            internal static extern void VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);

            [DllImport(Gl.Library, EntryPoint = "glVertexArrayAttribFormat", ExactSpelling = true)]
            internal static extern void VertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset);

            [DllImport(Gl.Library, EntryPoint = "glVertexArrayAttribIFormat", ExactSpelling = true)]
            internal static extern void VertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);

            [DllImport(Gl.Library, EntryPoint = "glVertexArrayAttribLFormat", ExactSpelling = true)]
            internal static extern void VertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
            internal static extern void VertexAttribPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribIPointer", ExactSpelling = true)]
            internal static extern void VertexAttribIPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);

            [DllImport(Gl.Library, EntryPoint = "glVertexAttribLPointer", ExactSpelling = true)]
            internal static extern void VertexAttribLPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);

            [DllImport(Gl.Library, EntryPoint = "glVertexBindingDivisor", ExactSpelling = true)]
            internal static extern void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);

            [DllImport(Gl.Library, EntryPoint = "glVertexArrayBindingDivisor", ExactSpelling = true)]
            internal static extern void VertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

            [DllImport(Gl.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal static extern void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);

            [DllImport(Gl.Library, EntryPoint = "glViewportArrayv", ExactSpelling = true)]
            internal static extern void ViewportArrayv(UInt32 first, Int32 count, Single[] v);

            [DllImport(Gl.Library, EntryPoint = "glViewportIndexedf", ExactSpelling = true)]
            internal static extern void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);

            [DllImport(Gl.Library, EntryPoint = "glViewportIndexedfv", ExactSpelling = true)]
            internal static extern void ViewportIndexedfv(UInt32 index, Single[] v);

            [DllImport(Gl.Library, EntryPoint = "glWaitSync", ExactSpelling = true)]
            internal static extern void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
        }
    }
}