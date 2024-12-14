using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011AB RID: 4523
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartCocoonStageScRsp : IMessage<StartCocoonStageScRsp>, IMessage, IEquatable<StartCocoonStageScRsp>, IDeepCloneable<StartCocoonStageScRsp>, IBufferMessage
	{
		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600C9F2 RID: 51698 RVA: 0x0021DB9F File Offset: 0x0021BD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartCocoonStageScRsp> Parser
		{
			get
			{
				return StartCocoonStageScRsp._parser;
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600C9F3 RID: 51699 RVA: 0x0021DBA6 File Offset: 0x0021BDA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartCocoonStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600C9F4 RID: 51700 RVA: 0x0021DBB8 File Offset: 0x0021BDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartCocoonStageScRsp.Descriptor;
			}
		}

		// Token: 0x0600C9F5 RID: 51701 RVA: 0x0021DBBF File Offset: 0x0021BDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartCocoonStageScRsp()
		{
		}

		// Token: 0x0600C9F6 RID: 51702 RVA: 0x0021DBC8 File Offset: 0x0021BDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartCocoonStageScRsp(StartCocoonStageScRsp other) : this()
		{
			this.wave_ = other.wave_;
			this.propEntityId_ = other.propEntityId_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.cocoonId_ = other.cocoonId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9F7 RID: 51703 RVA: 0x0021DC38 File Offset: 0x0021BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartCocoonStageScRsp Clone()
		{
			return new StartCocoonStageScRsp(this);
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600C9F8 RID: 51704 RVA: 0x0021DC40 File Offset: 0x0021BE40
		// (set) Token: 0x0600C9F9 RID: 51705 RVA: 0x0021DC48 File Offset: 0x0021BE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Wave
		{
			get
			{
				return this.wave_;
			}
			set
			{
				this.wave_ = value;
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600C9FA RID: 51706 RVA: 0x0021DC51 File Offset: 0x0021BE51
		// (set) Token: 0x0600C9FB RID: 51707 RVA: 0x0021DC59 File Offset: 0x0021BE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600C9FC RID: 51708 RVA: 0x0021DC62 File Offset: 0x0021BE62
		// (set) Token: 0x0600C9FD RID: 51709 RVA: 0x0021DC6A File Offset: 0x0021BE6A
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

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600C9FE RID: 51710 RVA: 0x0021DC73 File Offset: 0x0021BE73
		// (set) Token: 0x0600C9FF RID: 51711 RVA: 0x0021DC7B File Offset: 0x0021BE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CocoonId
		{
			get
			{
				return this.cocoonId_;
			}
			set
			{
				this.cocoonId_ = value;
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600CA00 RID: 51712 RVA: 0x0021DC84 File Offset: 0x0021BE84
		// (set) Token: 0x0600CA01 RID: 51713 RVA: 0x0021DC8C File Offset: 0x0021BE8C
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

		// Token: 0x0600CA02 RID: 51714 RVA: 0x0021DC95 File Offset: 0x0021BE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartCocoonStageScRsp);
		}

		// Token: 0x0600CA03 RID: 51715 RVA: 0x0021DCA4 File Offset: 0x0021BEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartCocoonStageScRsp other)
		{
			return other != null && (other == this || (this.Wave == other.Wave && this.PropEntityId == other.PropEntityId && object.Equals(this.BattleInfo, other.BattleInfo) && this.CocoonId == other.CocoonId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA04 RID: 51716 RVA: 0x0021DD24 File Offset: 0x0021BF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.CocoonId != 0U)
			{
				num ^= this.CocoonId.GetHashCode();
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

		// Token: 0x0600CA05 RID: 51717 RVA: 0x0021DDC4 File Offset: 0x0021BFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CA06 RID: 51718 RVA: 0x0021DDCC File Offset: 0x0021BFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA07 RID: 51719 RVA: 0x0021DDD8 File Offset: 0x0021BFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Wave);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CocoonId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.CocoonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA08 RID: 51720 RVA: 0x0021DE88 File Offset: 0x0021C088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.CocoonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CocoonId);
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

		// Token: 0x0600CA09 RID: 51721 RVA: 0x0021DF28 File Offset: 0x0021C128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartCocoonStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.CocoonId != 0U)
			{
				this.CocoonId = other.CocoonId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x0021DFCC File Offset: 0x0021C1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA0B RID: 51723 RVA: 0x0021DFD8 File Offset: 0x0021C1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 32U)
					{
						this.PropEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Wave = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.CocoonId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005174 RID: 20852
		private static readonly MessageParser<StartCocoonStageScRsp> _parser = new MessageParser<StartCocoonStageScRsp>(() => new StartCocoonStageScRsp());

		// Token: 0x04005175 RID: 20853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005176 RID: 20854
		public const int WaveFieldNumber = 9;

		// Token: 0x04005177 RID: 20855
		private uint wave_;

		// Token: 0x04005178 RID: 20856
		public const int PropEntityIdFieldNumber = 4;

		// Token: 0x04005179 RID: 20857
		private uint propEntityId_;

		// Token: 0x0400517A RID: 20858
		public const int BattleInfoFieldNumber = 7;

		// Token: 0x0400517B RID: 20859
		private SceneBattleInfo battleInfo_;

		// Token: 0x0400517C RID: 20860
		public const int CocoonIdFieldNumber = 14;

		// Token: 0x0400517D RID: 20861
		private uint cocoonId_;

		// Token: 0x0400517E RID: 20862
		public const int RetcodeFieldNumber = 13;

		// Token: 0x0400517F RID: 20863
		private uint retcode_;
	}
}
