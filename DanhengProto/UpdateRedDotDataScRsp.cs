using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013F1 RID: 5105
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateRedDotDataScRsp : IMessage<UpdateRedDotDataScRsp>, IMessage, IEquatable<UpdateRedDotDataScRsp>, IDeepCloneable<UpdateRedDotDataScRsp>, IBufferMessage
	{
		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x0600E39C RID: 58268 RVA: 0x0025D625 File Offset: 0x0025B825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateRedDotDataScRsp> Parser
		{
			get
			{
				return UpdateRedDotDataScRsp._parser;
			}
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x0600E39D RID: 58269 RVA: 0x0025D62C File Offset: 0x0025B82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateRedDotDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x0600E39E RID: 58270 RVA: 0x0025D63E File Offset: 0x0025B83E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRedDotDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600E39F RID: 58271 RVA: 0x0025D645 File Offset: 0x0025B845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRedDotDataScRsp()
		{
		}

		// Token: 0x0600E3A0 RID: 58272 RVA: 0x0025D650 File Offset: 0x0025B850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRedDotDataScRsp(UpdateRedDotDataScRsp other) : this()
		{
			this.groupId_ = other.groupId_;
			this.panelId_ = other.panelId_;
			this.retcode_ = other.retcode_;
			this.aCPLFDCNGKO_ = other.aCPLFDCNGKO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3A1 RID: 58273 RVA: 0x0025D6A4 File Offset: 0x0025B8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRedDotDataScRsp Clone()
		{
			return new UpdateRedDotDataScRsp(this);
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x0600E3A2 RID: 58274 RVA: 0x0025D6AC File Offset: 0x0025B8AC
		// (set) Token: 0x0600E3A3 RID: 58275 RVA: 0x0025D6B4 File Offset: 0x0025B8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x0600E3A4 RID: 58276 RVA: 0x0025D6BD File Offset: 0x0025B8BD
		// (set) Token: 0x0600E3A5 RID: 58277 RVA: 0x0025D6C5 File Offset: 0x0025B8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PanelId
		{
			get
			{
				return this.panelId_;
			}
			set
			{
				this.panelId_ = value;
			}
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x0600E3A6 RID: 58278 RVA: 0x0025D6CE File Offset: 0x0025B8CE
		// (set) Token: 0x0600E3A7 RID: 58279 RVA: 0x0025D6D6 File Offset: 0x0025B8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x0600E3A8 RID: 58280 RVA: 0x0025D6DF File Offset: 0x0025B8DF
		// (set) Token: 0x0600E3A9 RID: 58281 RVA: 0x0025D6E7 File Offset: 0x0025B8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ACPLFDCNGKO
		{
			get
			{
				return this.aCPLFDCNGKO_;
			}
			set
			{
				this.aCPLFDCNGKO_ = value;
			}
		}

		// Token: 0x0600E3AA RID: 58282 RVA: 0x0025D6F0 File Offset: 0x0025B8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRedDotDataScRsp);
		}

		// Token: 0x0600E3AB RID: 58283 RVA: 0x0025D700 File Offset: 0x0025B900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateRedDotDataScRsp other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.PanelId == other.PanelId && this.Retcode == other.Retcode && this.ACPLFDCNGKO == other.ACPLFDCNGKO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3AC RID: 58284 RVA: 0x0025D76C File Offset: 0x0025B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				num ^= this.ACPLFDCNGKO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3AD RID: 58285 RVA: 0x0025D7F6 File Offset: 0x0025B9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E3AE RID: 58286 RVA: 0x0025D7FE File Offset: 0x0025B9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3AF RID: 58287 RVA: 0x0025D808 File Offset: 0x0025BA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ACPLFDCNGKO != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ACPLFDCNGKO);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.PanelId);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3B0 RID: 58288 RVA: 0x0025D89C File Offset: 0x0025BA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ACPLFDCNGKO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3B1 RID: 58289 RVA: 0x0025D924 File Offset: 0x0025BB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateRedDotDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ACPLFDCNGKO != 0U)
			{
				this.ACPLFDCNGKO = other.ACPLFDCNGKO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3B2 RID: 58290 RVA: 0x0025D99C File Offset: 0x0025BB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3B3 RID: 58291 RVA: 0x0025D9A8 File Offset: 0x0025BBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 72U)
					{
						this.ACPLFDCNGKO = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.PanelId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A78 RID: 23160
		private static readonly MessageParser<UpdateRedDotDataScRsp> _parser = new MessageParser<UpdateRedDotDataScRsp>(() => new UpdateRedDotDataScRsp());

		// Token: 0x04005A79 RID: 23161
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A7A RID: 23162
		public const int GroupIdFieldNumber = 15;

		// Token: 0x04005A7B RID: 23163
		private uint groupId_;

		// Token: 0x04005A7C RID: 23164
		public const int PanelIdFieldNumber = 14;

		// Token: 0x04005A7D RID: 23165
		private uint panelId_;

		// Token: 0x04005A7E RID: 23166
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04005A7F RID: 23167
		private uint retcode_;

		// Token: 0x04005A80 RID: 23168
		public const int ACPLFDCNGKOFieldNumber = 9;

		// Token: 0x04005A81 RID: 23169
		private uint aCPLFDCNGKO_;
	}
}
