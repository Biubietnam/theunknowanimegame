using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000951 RID: 2385
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JBBIBKOIEDB : IMessage<JBBIBKOIEDB>, IMessage, IEquatable<JBBIBKOIEDB>, IDeepCloneable<JBBIBKOIEDB>, IBufferMessage
	{
		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x0011C2EA File Offset: 0x0011A4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JBBIBKOIEDB> Parser
		{
			get
			{
				return JBBIBKOIEDB._parser;
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06006A80 RID: 27264 RVA: 0x0011C2F1 File Offset: 0x0011A4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JBBIBKOIEDBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x0011C303 File Offset: 0x0011A503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JBBIBKOIEDB.Descriptor;
			}
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x0011C30A File Offset: 0x0011A50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBBIBKOIEDB()
		{
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x0011C312 File Offset: 0x0011A512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBBIBKOIEDB(JBBIBKOIEDB other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x0011C32B File Offset: 0x0011A52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBBIBKOIEDB Clone()
		{
			return new JBBIBKOIEDB(this);
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x0011C333 File Offset: 0x0011A533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JBBIBKOIEDB);
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x0011C341 File Offset: 0x0011A541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JBBIBKOIEDB other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x0011C360 File Offset: 0x0011A560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x0011C386 File Offset: 0x0011A586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x0011C38E File Offset: 0x0011A58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0011C397 File Offset: 0x0011A597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x0011C3B0 File Offset: 0x0011A5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x0011C3D6 File Offset: 0x0011A5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JBBIBKOIEDB other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x0011C3F3 File Offset: 0x0011A5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x0011C3FC File Offset: 0x0011A5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040028CB RID: 10443
		private static readonly MessageParser<JBBIBKOIEDB> _parser = new MessageParser<JBBIBKOIEDB>(() => new JBBIBKOIEDB());

		// Token: 0x040028CC RID: 10444
		private UnknownFieldSet _unknownFields;
	}
}
