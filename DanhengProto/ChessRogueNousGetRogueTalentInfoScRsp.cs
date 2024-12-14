using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200025B RID: 603
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousGetRogueTalentInfoScRsp : IMessage<ChessRogueNousGetRogueTalentInfoScRsp>, IMessage, IEquatable<ChessRogueNousGetRogueTalentInfoScRsp>, IDeepCloneable<ChessRogueNousGetRogueTalentInfoScRsp>, IBufferMessage
	{
		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x0004DFE3 File Offset: 0x0004C1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousGetRogueTalentInfoScRsp> Parser
		{
			get
			{
				return ChessRogueNousGetRogueTalentInfoScRsp._parser;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0004DFEA File Offset: 0x0004C1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousGetRogueTalentInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0004DFFC File Offset: 0x0004C1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousGetRogueTalentInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0004E003 File Offset: 0x0004C203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousGetRogueTalentInfoScRsp()
		{
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0004E00C File Offset: 0x0004C20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousGetRogueTalentInfoScRsp(ChessRogueNousGetRogueTalentInfoScRsp other) : this()
		{
			this.fCAAGLKFAID_ = other.fCAAGLKFAID_;
			this.talentInfoList_ = ((other.talentInfoList_ != null) ? other.talentInfoList_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0004E064 File Offset: 0x0004C264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousGetRogueTalentInfoScRsp Clone()
		{
			return new ChessRogueNousGetRogueTalentInfoScRsp(this);
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0004E06C File Offset: 0x0004C26C
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0004E074 File Offset: 0x0004C274
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0004E07D File Offset: 0x0004C27D
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0004E085 File Offset: 0x0004C285
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

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0004E08E File Offset: 0x0004C28E
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0004E096 File Offset: 0x0004C296
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

		// Token: 0x06001B0A RID: 6922 RVA: 0x0004E09F File Offset: 0x0004C29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousGetRogueTalentInfoScRsp);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0004E0B0 File Offset: 0x0004C2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousGetRogueTalentInfoScRsp other)
		{
			return other != null && (other == this || (this.FCAAGLKFAID == other.FCAAGLKFAID && object.Equals(this.TalentInfoList, other.TalentInfoList) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0004E110 File Offset: 0x0004C310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FCAAGLKFAID != 0U)
			{
				num ^= this.FCAAGLKFAID.GetHashCode();
			}
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

		// Token: 0x06001B0D RID: 6925 RVA: 0x0004E17E File Offset: 0x0004C37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0004E186 File Offset: 0x0004C386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0004E190 File Offset: 0x0004C390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.talentInfoList_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TalentInfoList);
			}
			if (this.FCAAGLKFAID != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.FCAAGLKFAID);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0004E208 File Offset: 0x0004C408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FCAAGLKFAID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FCAAGLKFAID);
			}
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

		// Token: 0x06001B11 RID: 6929 RVA: 0x0004E278 File Offset: 0x0004C478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousGetRogueTalentInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FCAAGLKFAID != 0U)
			{
				this.FCAAGLKFAID = other.FCAAGLKFAID;
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

		// Token: 0x06001B12 RID: 6930 RVA: 0x0004E2F4 File Offset: 0x0004C4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0004E300 File Offset: 0x0004C500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 64U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.FCAAGLKFAID = input.ReadUInt32();
					}
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
		}

		// Token: 0x04000B65 RID: 2917
		private static readonly MessageParser<ChessRogueNousGetRogueTalentInfoScRsp> _parser = new MessageParser<ChessRogueNousGetRogueTalentInfoScRsp>(() => new ChessRogueNousGetRogueTalentInfoScRsp());

		// Token: 0x04000B66 RID: 2918
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B67 RID: 2919
		public const int FCAAGLKFAIDFieldNumber = 8;

		// Token: 0x04000B68 RID: 2920
		private uint fCAAGLKFAID_;

		// Token: 0x04000B69 RID: 2921
		public const int TalentInfoListFieldNumber = 6;

		// Token: 0x04000B6A RID: 2922
		private RogueTalentInfoList talentInfoList_;

		// Token: 0x04000B6B RID: 2923
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04000B6C RID: 2924
		private uint retcode_;
	}
}
