using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C09 RID: 3081
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NEKKDMCDGPK : IMessage<NEKKDMCDGPK>, IMessage, IEquatable<NEKKDMCDGPK>, IDeepCloneable<NEKKDMCDGPK>, IBufferMessage
	{
		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x06008864 RID: 34916 RVA: 0x001680E0 File Offset: 0x001662E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NEKKDMCDGPK> Parser
		{
			get
			{
				return NEKKDMCDGPK._parser;
			}
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x06008865 RID: 34917 RVA: 0x001680E7 File Offset: 0x001662E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NEKKDMCDGPKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x06008866 RID: 34918 RVA: 0x001680F9 File Offset: 0x001662F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NEKKDMCDGPK.Descriptor;
			}
		}

		// Token: 0x06008867 RID: 34919 RVA: 0x00168100 File Offset: 0x00166300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NEKKDMCDGPK()
		{
		}

		// Token: 0x06008868 RID: 34920 RVA: 0x00168108 File Offset: 0x00166308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NEKKDMCDGPK(NEKKDMCDGPK other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.nLEDKNNAEPB_ = other.nLEDKNNAEPB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008869 RID: 34921 RVA: 0x00168139 File Offset: 0x00166339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NEKKDMCDGPK Clone()
		{
			return new NEKKDMCDGPK(this);
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x0600886A RID: 34922 RVA: 0x00168141 File Offset: 0x00166341
		// (set) Token: 0x0600886B RID: 34923 RVA: 0x00168149 File Offset: 0x00166349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x0600886C RID: 34924 RVA: 0x00168152 File Offset: 0x00166352
		// (set) Token: 0x0600886D RID: 34925 RVA: 0x0016815A File Offset: 0x0016635A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NLEDKNNAEPB
		{
			get
			{
				return this.nLEDKNNAEPB_;
			}
			set
			{
				this.nLEDKNNAEPB_ = value;
			}
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x00168163 File Offset: 0x00166363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NEKKDMCDGPK);
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x00168171 File Offset: 0x00166371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NEKKDMCDGPK other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.NLEDKNNAEPB == other.NLEDKNNAEPB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x001681B0 File Offset: 0x001663B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.NLEDKNNAEPB != 0)
			{
				num ^= this.NLEDKNNAEPB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x00168208 File Offset: 0x00166408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x00168210 File Offset: 0x00166410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008873 RID: 34931 RVA: 0x0016821C File Offset: 0x0016641C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.NLEDKNNAEPB != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NLEDKNNAEPB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x00168274 File Offset: 0x00166474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.NLEDKNNAEPB != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NLEDKNNAEPB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x001682CC File Offset: 0x001664CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NEKKDMCDGPK other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.NLEDKNNAEPB != 0)
			{
				this.NLEDKNNAEPB = other.NLEDKNNAEPB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x0016831C File Offset: 0x0016651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x00168328 File Offset: 0x00166528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NLEDKNNAEPB = input.ReadInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400344A RID: 13386
		private static readonly MessageParser<NEKKDMCDGPK> _parser = new MessageParser<NEKKDMCDGPK>(() => new NEKKDMCDGPK());

		// Token: 0x0400344B RID: 13387
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400344C RID: 13388
		public const int AvatarIdFieldNumber = 1;

		// Token: 0x0400344D RID: 13389
		private uint avatarId_;

		// Token: 0x0400344E RID: 13390
		public const int NLEDKNNAEPBFieldNumber = 2;

		// Token: 0x0400344F RID: 13391
		private int nLEDKNNAEPB_;
	}
}
