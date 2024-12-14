using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007D7 RID: 2007
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueTalentInfoScRsp : IMessage<GetRogueTalentInfoScRsp>, IMessage, IEquatable<GetRogueTalentInfoScRsp>, IDeepCloneable<GetRogueTalentInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06005982 RID: 22914 RVA: 0x000EED5B File Offset: 0x000ECF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueTalentInfoScRsp> Parser
		{
			get
			{
				return GetRogueTalentInfoScRsp._parser;
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06005983 RID: 22915 RVA: 0x000EED62 File Offset: 0x000ECF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueTalentInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06005984 RID: 22916 RVA: 0x000EED74 File Offset: 0x000ECF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueTalentInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x000EED7B File Offset: 0x000ECF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueTalentInfoScRsp()
		{
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x000EED84 File Offset: 0x000ECF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueTalentInfoScRsp(GetRogueTalentInfoScRsp other) : this()
		{
			this.talentInfoList_ = ((other.talentInfoList_ != null) ? other.talentInfoList_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x000EEDD0 File Offset: 0x000ECFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueTalentInfoScRsp Clone()
		{
			return new GetRogueTalentInfoScRsp(this);
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x000EEDD8 File Offset: 0x000ECFD8
		// (set) Token: 0x06005989 RID: 22921 RVA: 0x000EEDE0 File Offset: 0x000ECFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfoList TalentInfoList
		{
			get
			{
				return this.talentInfoList_;
			}
			set
			{
				this.talentInfoList_ = value;
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x0600598A RID: 22922 RVA: 0x000EEDE9 File Offset: 0x000ECFE9
		// (set) Token: 0x0600598B RID: 22923 RVA: 0x000EEDF1 File Offset: 0x000ECFF1
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

		// Token: 0x0600598C RID: 22924 RVA: 0x000EEDFA File Offset: 0x000ECFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueTalentInfoScRsp);
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x000EEE08 File Offset: 0x000ED008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueTalentInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.TalentInfoList, other.TalentInfoList) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x000EEE58 File Offset: 0x000ED058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.talentInfoList_ != null)
			{
				num ^= this.TalentInfoList.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x000EEEAD File Offset: 0x000ED0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x000EEEB5 File Offset: 0x000ED0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x000EEEC0 File Offset: 0x000ED0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.talentInfoList_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TalentInfoList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x000EEF1C File Offset: 0x000ED11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.talentInfoList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TalentInfoList);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x000EEF74 File Offset: 0x000ED174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueTalentInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.talentInfoList_ != null)
			{
				if (this.talentInfoList_ == null)
				{
					this.TalentInfoList = new RogueTalentInfoList();
				}
				this.TalentInfoList.MergeFrom(other.TalentInfoList);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x000EEFDC File Offset: 0x000ED1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x000EEFE8 File Offset: 0x000ED1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.talentInfoList_ == null)
						{
							this.TalentInfoList = new RogueTalentInfoList();
						}
						input.ReadMessage(this.TalentInfoList);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040022C6 RID: 8902
		private static readonly MessageParser<GetRogueTalentInfoScRsp> _parser = new MessageParser<GetRogueTalentInfoScRsp>(() => new GetRogueTalentInfoScRsp());

		// Token: 0x040022C7 RID: 8903
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022C8 RID: 8904
		public const int TalentInfoListFieldNumber = 15;

		// Token: 0x040022C9 RID: 8905
		private RogueTalentInfoList talentInfoList_;

		// Token: 0x040022CA RID: 8906
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040022CB RID: 8907
		private uint retcode_;
	}
}
