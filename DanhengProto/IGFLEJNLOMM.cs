using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200091F RID: 2335
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IGFLEJNLOMM : IMessage<IGFLEJNLOMM>, IMessage, IEquatable<IGFLEJNLOMM>, IDeepCloneable<IGFLEJNLOMM>, IBufferMessage
	{
		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06006828 RID: 26664 RVA: 0x0011644C File Offset: 0x0011464C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IGFLEJNLOMM> Parser
		{
			get
			{
				return IGFLEJNLOMM._parser;
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x00116453 File Offset: 0x00114653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IGFLEJNLOMMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x0600682A RID: 26666 RVA: 0x00116465 File Offset: 0x00114665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IGFLEJNLOMM.Descriptor;
			}
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x0011646C File Offset: 0x0011466C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IGFLEJNLOMM()
		{
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00116474 File Offset: 0x00114674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IGFLEJNLOMM(IGFLEJNLOMM other) : this()
		{
			this.jIJIEKNBNPE_ = other.jIJIEKNBNPE_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x001164A5 File Offset: 0x001146A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IGFLEJNLOMM Clone()
		{
			return new IGFLEJNLOMM(this);
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x0600682E RID: 26670 RVA: 0x001164AD File Offset: 0x001146AD
		// (set) Token: 0x0600682F RID: 26671 RVA: 0x001164B5 File Offset: 0x001146B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIJIEKNBNPE
		{
			get
			{
				return this.jIJIEKNBNPE_;
			}
			set
			{
				this.jIJIEKNBNPE_ = value;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06006830 RID: 26672 RVA: 0x001164BE File Offset: 0x001146BE
		// (set) Token: 0x06006831 RID: 26673 RVA: 0x001164C6 File Offset: 0x001146C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x001164CF File Offset: 0x001146CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IGFLEJNLOMM);
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x001164DD File Offset: 0x001146DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IGFLEJNLOMM other)
		{
			return other != null && (other == this || (this.JIJIEKNBNPE == other.JIJIEKNBNPE && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x0011651C File Offset: 0x0011471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JIJIEKNBNPE != 0U)
			{
				num ^= this.JIJIEKNBNPE.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x00116574 File Offset: 0x00114774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x0011657C File Offset: 0x0011477C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x00116588 File Offset: 0x00114788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Num != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Num);
			}
			if (this.JIJIEKNBNPE != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.JIJIEKNBNPE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x001165E4 File Offset: 0x001147E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JIJIEKNBNPE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIJIEKNBNPE);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x0011663C File Offset: 0x0011483C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IGFLEJNLOMM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JIJIEKNBNPE != 0U)
			{
				this.JIJIEKNBNPE = other.JIJIEKNBNPE;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x0011668C File Offset: 0x0011488C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x00116698 File Offset: 0x00114898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.JIJIEKNBNPE = input.ReadUInt32();
					}
				}
				else
				{
					this.Num = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040027FC RID: 10236
		private static readonly MessageParser<IGFLEJNLOMM> _parser = new MessageParser<IGFLEJNLOMM>(() => new IGFLEJNLOMM());

		// Token: 0x040027FD RID: 10237
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027FE RID: 10238
		public const int JIJIEKNBNPEFieldNumber = 15;

		// Token: 0x040027FF RID: 10239
		private uint jIJIEKNBNPE_;

		// Token: 0x04002800 RID: 10240
		public const int NumFieldNumber = 12;

		// Token: 0x04002801 RID: 10241
		private uint num_;
	}
}
