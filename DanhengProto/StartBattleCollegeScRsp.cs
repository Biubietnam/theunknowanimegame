using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200119F RID: 4511
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartBattleCollegeScRsp : IMessage<StartBattleCollegeScRsp>, IMessage, IEquatable<StartBattleCollegeScRsp>, IDeepCloneable<StartBattleCollegeScRsp>, IBufferMessage
	{
		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600C95B RID: 51547 RVA: 0x0021C02F File Offset: 0x0021A22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartBattleCollegeScRsp> Parser
		{
			get
			{
				return StartBattleCollegeScRsp._parser;
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600C95C RID: 51548 RVA: 0x0021C036 File Offset: 0x0021A236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartBattleCollegeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600C95D RID: 51549 RVA: 0x0021C048 File Offset: 0x0021A248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartBattleCollegeScRsp.Descriptor;
			}
		}

		// Token: 0x0600C95E RID: 51550 RVA: 0x0021C04F File Offset: 0x0021A24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBattleCollegeScRsp()
		{
		}

		// Token: 0x0600C95F RID: 51551 RVA: 0x0021C058 File Offset: 0x0021A258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBattleCollegeScRsp(StartBattleCollegeScRsp other) : this()
		{
			this.id_ = other.id_;
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x0021C0B0 File Offset: 0x0021A2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBattleCollegeScRsp Clone()
		{
			return new StartBattleCollegeScRsp(this);
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600C961 RID: 51553 RVA: 0x0021C0B8 File Offset: 0x0021A2B8
		// (set) Token: 0x0600C962 RID: 51554 RVA: 0x0021C0C0 File Offset: 0x0021A2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600C963 RID: 51555 RVA: 0x0021C0C9 File Offset: 0x0021A2C9
		// (set) Token: 0x0600C964 RID: 51556 RVA: 0x0021C0D1 File Offset: 0x0021A2D1
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

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600C965 RID: 51557 RVA: 0x0021C0DA File Offset: 0x0021A2DA
		// (set) Token: 0x0600C966 RID: 51558 RVA: 0x0021C0E2 File Offset: 0x0021A2E2
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

		// Token: 0x0600C967 RID: 51559 RVA: 0x0021C0EB File Offset: 0x0021A2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartBattleCollegeScRsp);
		}

		// Token: 0x0600C968 RID: 51560 RVA: 0x0021C0FC File Offset: 0x0021A2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartBattleCollegeScRsp other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x0021C15C File Offset: 0x0021A35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
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

		// Token: 0x0600C96A RID: 51562 RVA: 0x0021C1CA File Offset: 0x0021A3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x0021C1D2 File Offset: 0x0021A3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C96C RID: 51564 RVA: 0x0021C1DC File Offset: 0x0021A3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C96D RID: 51565 RVA: 0x0021C254 File Offset: 0x0021A454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
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

		// Token: 0x0600C96E RID: 51566 RVA: 0x0021C2C4 File Offset: 0x0021A4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartBattleCollegeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
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

		// Token: 0x0600C96F RID: 51567 RVA: 0x0021C340 File Offset: 0x0021A540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C970 RID: 51568 RVA: 0x0021C34C File Offset: 0x0021A54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 42U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadUInt32();
						}
					}
					else
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005137 RID: 20791
		private static readonly MessageParser<StartBattleCollegeScRsp> _parser = new MessageParser<StartBattleCollegeScRsp>(() => new StartBattleCollegeScRsp());

		// Token: 0x04005138 RID: 20792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005139 RID: 20793
		public const int IdFieldNumber = 9;

		// Token: 0x0400513A RID: 20794
		private uint id_;

		// Token: 0x0400513B RID: 20795
		public const int RetcodeFieldNumber = 2;

		// Token: 0x0400513C RID: 20796
		private uint retcode_;

		// Token: 0x0400513D RID: 20797
		public const int BattleInfoFieldNumber = 5;

		// Token: 0x0400513E RID: 20798
		private SceneBattleInfo battleInfo_;
	}
}
