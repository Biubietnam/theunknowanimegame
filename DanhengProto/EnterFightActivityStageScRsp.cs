using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200044D RID: 1101
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterFightActivityStageScRsp : IMessage<EnterFightActivityStageScRsp>, IMessage, IEquatable<EnterFightActivityStageScRsp>, IDeepCloneable<EnterFightActivityStageScRsp>, IBufferMessage
	{
		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x000867EF File Offset: 0x000849EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterFightActivityStageScRsp> Parser
		{
			get
			{
				return EnterFightActivityStageScRsp._parser;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x000867F6 File Offset: 0x000849F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterFightActivityStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x00086808 File Offset: 0x00084A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterFightActivityStageScRsp.Descriptor;
			}
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0008680F File Offset: 0x00084A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFightActivityStageScRsp()
		{
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x00086818 File Offset: 0x00084A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFightActivityStageScRsp(EnterFightActivityStageScRsp other) : this()
		{
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x0008687C File Offset: 0x00084A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFightActivityStageScRsp Clone()
		{
			return new EnterFightActivityStageScRsp(this);
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x00086884 File Offset: 0x00084A84
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x0008688C File Offset: 0x00084A8C
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

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x00086895 File Offset: 0x00084A95
		// (set) Token: 0x060030F9 RID: 12537 RVA: 0x0008689D File Offset: 0x00084A9D
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

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x000868A6 File Offset: 0x00084AA6
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x000868AE File Offset: 0x00084AAE
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

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x000868B7 File Offset: 0x00084AB7
		// (set) Token: 0x060030FD RID: 12541 RVA: 0x000868BF File Offset: 0x00084ABF
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

		// Token: 0x060030FE RID: 12542 RVA: 0x000868C8 File Offset: 0x00084AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterFightActivityStageScRsp);
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000868D8 File Offset: 0x00084AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterFightActivityStageScRsp other)
		{
			return other != null && (other == this || (this.AHFNGPLDAII == other.AHFNGPLDAII && object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x00086948 File Offset: 0x00084B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000869CF File Offset: 0x00084BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x000869D7 File Offset: 0x00084BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x000869E0 File Offset: 0x00084BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GroupId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00086A74 File Offset: 0x00084C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00086AFC File Offset: 0x00084CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterFightActivityStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x00086B8C File Offset: 0x00084D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x00086B98 File Offset: 0x00084D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 40U)
					{
						this.AHFNGPLDAII = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
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

		// Token: 0x0400137D RID: 4989
		private static readonly MessageParser<EnterFightActivityStageScRsp> _parser = new MessageParser<EnterFightActivityStageScRsp>(() => new EnterFightActivityStageScRsp());

		// Token: 0x0400137E RID: 4990
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400137F RID: 4991
		public const int AHFNGPLDAIIFieldNumber = 5;

		// Token: 0x04001380 RID: 4992
		private uint aHFNGPLDAII_;

		// Token: 0x04001381 RID: 4993
		public const int BattleInfoFieldNumber = 15;

		// Token: 0x04001382 RID: 4994
		private SceneBattleInfo battleInfo_;

		// Token: 0x04001383 RID: 4995
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04001384 RID: 4996
		private uint retcode_;

		// Token: 0x04001385 RID: 4997
		public const int GroupIdFieldNumber = 9;

		// Token: 0x04001386 RID: 4998
		private uint groupId_;
	}
}
