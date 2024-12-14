using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C0F RID: 3087
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NFFJMFGNHKO : IMessage<NFFJMFGNHKO>, IMessage, IEquatable<NFFJMFGNHKO>, IDeepCloneable<NFFJMFGNHKO>, IBufferMessage
	{
		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x060088A4 RID: 34980 RVA: 0x001688E8 File Offset: 0x00166AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NFFJMFGNHKO> Parser
		{
			get
			{
				return NFFJMFGNHKO._parser;
			}
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x060088A5 RID: 34981 RVA: 0x001688EF File Offset: 0x00166AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NFFJMFGNHKOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x060088A6 RID: 34982 RVA: 0x00168901 File Offset: 0x00166B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NFFJMFGNHKO.Descriptor;
			}
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x00168908 File Offset: 0x00166B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFFJMFGNHKO()
		{
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x00168910 File Offset: 0x00166B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFFJMFGNHKO(NFFJMFGNHKO other) : this()
		{
			this.buffSelectId_ = other.buffSelectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x00168935 File Offset: 0x00166B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFFJMFGNHKO Clone()
		{
			return new NFFJMFGNHKO(this);
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x060088AA RID: 34986 RVA: 0x0016893D File Offset: 0x00166B3D
		// (set) Token: 0x060088AB RID: 34987 RVA: 0x00168945 File Offset: 0x00166B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffSelectId
		{
			get
			{
				return this.buffSelectId_;
			}
			set
			{
				this.buffSelectId_ = value;
			}
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x0016894E File Offset: 0x00166B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NFFJMFGNHKO);
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x0016895C File Offset: 0x00166B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NFFJMFGNHKO other)
		{
			return other != null && (other == this || (this.BuffSelectId == other.BuffSelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x0016898C File Offset: 0x00166B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffSelectId != 0U)
			{
				num ^= this.BuffSelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088AF RID: 34991 RVA: 0x001689CB File Offset: 0x00166BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x001689D3 File Offset: 0x00166BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088B1 RID: 34993 RVA: 0x001689DC File Offset: 0x00166BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffSelectId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.BuffSelectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088B2 RID: 34994 RVA: 0x00168A10 File Offset: 0x00166C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffSelectId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffSelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088B3 RID: 34995 RVA: 0x00168A4E File Offset: 0x00166C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NFFJMFGNHKO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffSelectId != 0U)
			{
				this.BuffSelectId = other.BuffSelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x00168A7F File Offset: 0x00166C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088B5 RID: 34997 RVA: 0x00168A88 File Offset: 0x00166C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuffSelectId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400345C RID: 13404
		private static readonly MessageParser<NFFJMFGNHKO> _parser = new MessageParser<NFFJMFGNHKO>(() => new NFFJMFGNHKO());

		// Token: 0x0400345D RID: 13405
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400345E RID: 13406
		public const int BuffSelectIdFieldNumber = 9;

		// Token: 0x0400345F RID: 13407
		private uint buffSelectId_;
	}
}
