using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000257 RID: 599
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousEnableRogueTalentScRsp : IMessage<ChessRogueNousEnableRogueTalentScRsp>, IMessage, IEquatable<ChessRogueNousEnableRogueTalentScRsp>, IDeepCloneable<ChessRogueNousEnableRogueTalentScRsp>, IBufferMessage
	{
		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0004D9CB File Offset: 0x0004BBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousEnableRogueTalentScRsp> Parser
		{
			get
			{
				return ChessRogueNousEnableRogueTalentScRsp._parser;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0004D9D2 File Offset: 0x0004BBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousEnableRogueTalentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0004D9E4 File Offset: 0x0004BBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousEnableRogueTalentScRsp.Descriptor;
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0004D9EB File Offset: 0x0004BBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEnableRogueTalentScRsp()
		{
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0004D9F4 File Offset: 0x0004BBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEnableRogueTalentScRsp(ChessRogueNousEnableRogueTalentScRsp other) : this()
		{
			this.talentInfoList_ = ((other.talentInfoList_ != null) ? other.talentInfoList_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.fCAAGLKFAID_ = other.fCAAGLKFAID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0004DA4C File Offset: 0x0004BC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEnableRogueTalentScRsp Clone()
		{
			return new ChessRogueNousEnableRogueTalentScRsp(this);
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0004DA54 File Offset: 0x0004BC54
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0004DA5C File Offset: 0x0004BC5C
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

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0004DA65 File Offset: 0x0004BC65
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0004DA6D File Offset: 0x0004BC6D
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0004DA76 File Offset: 0x0004BC76
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0004DA7E File Offset: 0x0004BC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FCAAGLKFAID
		{
			get
			{
				return this.fCAAGLKFAID_;
			}
			set
			{
				this.fCAAGLKFAID_ = value;
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0004DA87 File Offset: 0x0004BC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousEnableRogueTalentScRsp);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0004DA98 File Offset: 0x0004BC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousEnableRogueTalentScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.TalentInfoList, other.TalentInfoList) && this.Retcode == other.Retcode && this.FCAAGLKFAID == other.FCAAGLKFAID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
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
			if (this.FCAAGLKFAID != 0U)
			{
				num ^= this.FCAAGLKFAID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0004DB66 File Offset: 0x0004BD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0004DB6E File Offset: 0x0004BD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0004DB78 File Offset: 0x0004BD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.FCAAGLKFAID != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.FCAAGLKFAID);
			}
			if (this.talentInfoList_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.TalentInfoList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0004DBF0 File Offset: 0x0004BDF0
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
			if (this.FCAAGLKFAID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FCAAGLKFAID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0004DC60 File Offset: 0x0004BE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousEnableRogueTalentScRsp other)
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
			if (other.FCAAGLKFAID != 0U)
			{
				this.FCAAGLKFAID = other.FCAAGLKFAID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0004DCDC File Offset: 0x0004BEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0004DCE8 File Offset: 0x0004BEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 72U)
					{
						if (num != 82U)
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
						this.FCAAGLKFAID = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000B59 RID: 2905
		private static readonly MessageParser<ChessRogueNousEnableRogueTalentScRsp> _parser = new MessageParser<ChessRogueNousEnableRogueTalentScRsp>(() => new ChessRogueNousEnableRogueTalentScRsp());

		// Token: 0x04000B5A RID: 2906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B5B RID: 2907
		public const int TalentInfoListFieldNumber = 10;

		// Token: 0x04000B5C RID: 2908
		private RogueTalentInfoList talentInfoList_;

		// Token: 0x04000B5D RID: 2909
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04000B5E RID: 2910
		private uint retcode_;

		// Token: 0x04000B5F RID: 2911
		public const int FCAAGLKFAIDFieldNumber = 9;

		// Token: 0x04000B60 RID: 2912
		private uint fCAAGLKFAID_;
	}
}
