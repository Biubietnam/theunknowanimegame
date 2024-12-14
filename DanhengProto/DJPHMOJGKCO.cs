using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003B5 RID: 949
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DJPHMOJGKCO : IMessage<DJPHMOJGKCO>, IMessage, IEquatable<DJPHMOJGKCO>, IDeepCloneable<DJPHMOJGKCO>, IBufferMessage
	{
		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000759DD File Offset: 0x00073BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DJPHMOJGKCO> Parser
		{
			get
			{
				return DJPHMOJGKCO._parser;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000759E4 File Offset: 0x00073BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DJPHMOJGKCOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000759F6 File Offset: 0x00073BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DJPHMOJGKCO.Descriptor;
			}
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x000759FD File Offset: 0x00073BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DJPHMOJGKCO()
		{
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00075A08 File Offset: 0x00073C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DJPHMOJGKCO(DJPHMOJGKCO other) : this()
		{
			this.iBMPGMBHHPP_ = other.iBMPGMBHHPP_;
			this.aEDDEMIGDGB_ = other.aEDDEMIGDGB_;
			this.oJDNJFDJIMP_ = other.oJDNJFDJIMP_;
			this.contentId_ = other.contentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00075A5C File Offset: 0x00073C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DJPHMOJGKCO Clone()
		{
			return new DJPHMOJGKCO(this);
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x00075A64 File Offset: 0x00073C64
		// (set) Token: 0x06002A47 RID: 10823 RVA: 0x00075A6C File Offset: 0x00073C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IBMPGMBHHPP
		{
			get
			{
				return this.iBMPGMBHHPP_;
			}
			set
			{
				this.iBMPGMBHHPP_ = value;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x00075A75 File Offset: 0x00073C75
		// (set) Token: 0x06002A49 RID: 10825 RVA: 0x00075A7D File Offset: 0x00073C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AEDDEMIGDGB
		{
			get
			{
				return this.aEDDEMIGDGB_;
			}
			set
			{
				this.aEDDEMIGDGB_ = value;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x00075A86 File Offset: 0x00073C86
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x00075A8E File Offset: 0x00073C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OJDNJFDJIMP
		{
			get
			{
				return this.oJDNJFDJIMP_;
			}
			set
			{
				this.oJDNJFDJIMP_ = value;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x00075A97 File Offset: 0x00073C97
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x00075A9F File Offset: 0x00073C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00075AA8 File Offset: 0x00073CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DJPHMOJGKCO);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00075AB8 File Offset: 0x00073CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DJPHMOJGKCO other)
		{
			return other != null && (other == this || (this.IBMPGMBHHPP == other.IBMPGMBHHPP && this.AEDDEMIGDGB == other.AEDDEMIGDGB && this.OJDNJFDJIMP == other.OJDNJFDJIMP && this.ContentId == other.ContentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00075B24 File Offset: 0x00073D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IBMPGMBHHPP != 0U)
			{
				num ^= this.IBMPGMBHHPP.GetHashCode();
			}
			if (this.AEDDEMIGDGB != 0U)
			{
				num ^= this.AEDDEMIGDGB.GetHashCode();
			}
			if (this.OJDNJFDJIMP != 0U)
			{
				num ^= this.OJDNJFDJIMP.GetHashCode();
			}
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00075BAE File Offset: 0x00073DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00075BB6 File Offset: 0x00073DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00075BC0 File Offset: 0x00073DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AEDDEMIGDGB != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AEDDEMIGDGB);
			}
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ContentId);
			}
			if (this.OJDNJFDJIMP != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.OJDNJFDJIMP);
			}
			if (this.IBMPGMBHHPP != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.IBMPGMBHHPP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00075C50 File Offset: 0x00073E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IBMPGMBHHPP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IBMPGMBHHPP);
			}
			if (this.AEDDEMIGDGB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AEDDEMIGDGB);
			}
			if (this.OJDNJFDJIMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OJDNJFDJIMP);
			}
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00075CD8 File Offset: 0x00073ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DJPHMOJGKCO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IBMPGMBHHPP != 0U)
			{
				this.IBMPGMBHHPP = other.IBMPGMBHHPP;
			}
			if (other.AEDDEMIGDGB != 0U)
			{
				this.AEDDEMIGDGB = other.AEDDEMIGDGB;
			}
			if (other.OJDNJFDJIMP != 0U)
			{
				this.OJDNJFDJIMP = other.OJDNJFDJIMP;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00075D50 File Offset: 0x00073F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00075D5C File Offset: 0x00073F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.AEDDEMIGDGB = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ContentId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.OJDNJFDJIMP = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IBMPGMBHHPP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001116 RID: 4374
		private static readonly MessageParser<DJPHMOJGKCO> _parser = new MessageParser<DJPHMOJGKCO>(() => new DJPHMOJGKCO());

		// Token: 0x04001117 RID: 4375
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001118 RID: 4376
		public const int IBMPGMBHHPPFieldNumber = 14;

		// Token: 0x04001119 RID: 4377
		private uint iBMPGMBHHPP_;

		// Token: 0x0400111A RID: 4378
		public const int AEDDEMIGDGBFieldNumber = 1;

		// Token: 0x0400111B RID: 4379
		private uint aEDDEMIGDGB_;

		// Token: 0x0400111C RID: 4380
		public const int OJDNJFDJIMPFieldNumber = 12;

		// Token: 0x0400111D RID: 4381
		private uint oJDNJFDJIMP_;

		// Token: 0x0400111E RID: 4382
		public const int ContentIdFieldNumber = 9;

		// Token: 0x0400111F RID: 4383
		private uint contentId_;
	}
}
