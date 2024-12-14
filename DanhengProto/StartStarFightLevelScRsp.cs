using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011CB RID: 4555
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartStarFightLevelScRsp : IMessage<StartStarFightLevelScRsp>, IMessage, IEquatable<StartStarFightLevelScRsp>, IDeepCloneable<StartStarFightLevelScRsp>, IBufferMessage
	{
		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0600CB8E RID: 52110 RVA: 0x00222717 File Offset: 0x00220917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartStarFightLevelScRsp> Parser
		{
			get
			{
				return StartStarFightLevelScRsp._parser;
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x0022271E File Offset: 0x0022091E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartStarFightLevelScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600CB90 RID: 52112 RVA: 0x00222730 File Offset: 0x00220930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartStarFightLevelScRsp.Descriptor;
			}
		}

		// Token: 0x0600CB91 RID: 52113 RVA: 0x00222737 File Offset: 0x00220937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartStarFightLevelScRsp()
		{
		}

		// Token: 0x0600CB92 RID: 52114 RVA: 0x00222740 File Offset: 0x00220940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartStarFightLevelScRsp(StartStarFightLevelScRsp other) : this()
		{
			this.groupId_ = other.groupId_;
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB93 RID: 52115 RVA: 0x002227A4 File Offset: 0x002209A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartStarFightLevelScRsp Clone()
		{
			return new StartStarFightLevelScRsp(this);
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600CB94 RID: 52116 RVA: 0x002227AC File Offset: 0x002209AC
		// (set) Token: 0x0600CB95 RID: 52117 RVA: 0x002227B4 File Offset: 0x002209B4
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

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600CB96 RID: 52118 RVA: 0x002227BD File Offset: 0x002209BD
		// (set) Token: 0x0600CB97 RID: 52119 RVA: 0x002227C5 File Offset: 0x002209C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600CB98 RID: 52120 RVA: 0x002227CE File Offset: 0x002209CE
		// (set) Token: 0x0600CB99 RID: 52121 RVA: 0x002227D6 File Offset: 0x002209D6
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

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600CB9A RID: 52122 RVA: 0x002227DF File Offset: 0x002209DF
		// (set) Token: 0x0600CB9B RID: 52123 RVA: 0x002227E7 File Offset: 0x002209E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x0600CB9C RID: 52124 RVA: 0x002227F0 File Offset: 0x002209F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartStarFightLevelScRsp);
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x00222800 File Offset: 0x00220A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartStarFightLevelScRsp other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.AHFNGPLDAII == other.AHFNGPLDAII && this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x00222870 File Offset: 0x00220A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB9F RID: 52127 RVA: 0x002228F7 File Offset: 0x00220AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x002228FF File Offset: 0x00220AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBA1 RID: 52129 RVA: 0x00222908 File Offset: 0x00220B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GroupId);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBA2 RID: 52130 RVA: 0x0022299C File Offset: 0x00220B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBA3 RID: 52131 RVA: 0x00222A24 File Offset: 0x00220C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartStarFightLevelScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBA4 RID: 52132 RVA: 0x00222AB4 File Offset: 0x00220CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBA5 RID: 52133 RVA: 0x00222AC0 File Offset: 0x00220CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.AHFNGPLDAII = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005220 RID: 21024
		private static readonly MessageParser<StartStarFightLevelScRsp> _parser = new MessageParser<StartStarFightLevelScRsp>(() => new StartStarFightLevelScRsp());

		// Token: 0x04005221 RID: 21025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005222 RID: 21026
		public const int GroupIdFieldNumber = 7;

		// Token: 0x04005223 RID: 21027
		private uint groupId_;

		// Token: 0x04005224 RID: 21028
		public const int AHFNGPLDAIIFieldNumber = 8;

		// Token: 0x04005225 RID: 21029
		private uint aHFNGPLDAII_;

		// Token: 0x04005226 RID: 21030
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04005227 RID: 21031
		private uint retcode_;

		// Token: 0x04005228 RID: 21032
		public const int BattleInfoFieldNumber = 13;

		// Token: 0x04005229 RID: 21033
		private SceneBattleInfo battleInfo_;
	}
}
