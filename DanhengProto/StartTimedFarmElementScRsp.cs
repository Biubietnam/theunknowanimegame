using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011D3 RID: 4563
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartTimedFarmElementScRsp : IMessage<StartTimedFarmElementScRsp>, IMessage, IEquatable<StartTimedFarmElementScRsp>, IDeepCloneable<StartTimedFarmElementScRsp>, IBufferMessage
	{
		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x0600CBF4 RID: 52212 RVA: 0x00223857 File Offset: 0x00221A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartTimedFarmElementScRsp> Parser
		{
			get
			{
				return StartTimedFarmElementScRsp._parser;
			}
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600CBF5 RID: 52213 RVA: 0x0022385E File Offset: 0x00221A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartTimedFarmElementScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600CBF6 RID: 52214 RVA: 0x00223870 File Offset: 0x00221A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartTimedFarmElementScRsp.Descriptor;
			}
		}

		// Token: 0x0600CBF7 RID: 52215 RVA: 0x00223877 File Offset: 0x00221A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedFarmElementScRsp()
		{
		}

		// Token: 0x0600CBF8 RID: 52216 RVA: 0x00223880 File Offset: 0x00221A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedFarmElementScRsp(StartTimedFarmElementScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.worldLevel_ = other.worldLevel_;
			this.pOLKBGLCBJD_ = other.pOLKBGLCBJD_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBF9 RID: 52217 RVA: 0x002238E4 File Offset: 0x00221AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedFarmElementScRsp Clone()
		{
			return new StartTimedFarmElementScRsp(this);
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600CBFA RID: 52218 RVA: 0x002238EC File Offset: 0x00221AEC
		// (set) Token: 0x0600CBFB RID: 52219 RVA: 0x002238F4 File Offset: 0x00221AF4
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

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600CBFC RID: 52220 RVA: 0x002238FD File Offset: 0x00221AFD
		// (set) Token: 0x0600CBFD RID: 52221 RVA: 0x00223905 File Offset: 0x00221B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0600CBFE RID: 52222 RVA: 0x0022390E File Offset: 0x00221B0E
		// (set) Token: 0x0600CBFF RID: 52223 RVA: 0x00223916 File Offset: 0x00221B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POLKBGLCBJD
		{
			get
			{
				return this.pOLKBGLCBJD_;
			}
			set
			{
				this.pOLKBGLCBJD_ = value;
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0600CC00 RID: 52224 RVA: 0x0022391F File Offset: 0x00221B1F
		// (set) Token: 0x0600CC01 RID: 52225 RVA: 0x00223927 File Offset: 0x00221B27
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

		// Token: 0x0600CC02 RID: 52226 RVA: 0x00223930 File Offset: 0x00221B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartTimedFarmElementScRsp);
		}

		// Token: 0x0600CC03 RID: 52227 RVA: 0x00223940 File Offset: 0x00221B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartTimedFarmElementScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.WorldLevel == other.WorldLevel && this.POLKBGLCBJD == other.POLKBGLCBJD && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC04 RID: 52228 RVA: 0x002239B0 File Offset: 0x00221BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.POLKBGLCBJD != 0U)
			{
				num ^= this.POLKBGLCBJD.GetHashCode();
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

		// Token: 0x0600CC05 RID: 52229 RVA: 0x00223A37 File Offset: 0x00221C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CC06 RID: 52230 RVA: 0x00223A3F File Offset: 0x00221C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC07 RID: 52231 RVA: 0x00223A48 File Offset: 0x00221C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.POLKBGLCBJD != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.POLKBGLCBJD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC08 RID: 52232 RVA: 0x00223AD8 File Offset: 0x00221CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.POLKBGLCBJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POLKBGLCBJD);
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

		// Token: 0x0600CC09 RID: 52233 RVA: 0x00223B60 File Offset: 0x00221D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartTimedFarmElementScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.POLKBGLCBJD != 0U)
			{
				this.POLKBGLCBJD = other.POLKBGLCBJD;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC0A RID: 52234 RVA: 0x00223BF0 File Offset: 0x00221DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC0B RID: 52235 RVA: 0x00223BFC File Offset: 0x00221DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
					if (num == 18U)
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
					if (num == 88U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.POLKBGLCBJD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005246 RID: 21062
		private static readonly MessageParser<StartTimedFarmElementScRsp> _parser = new MessageParser<StartTimedFarmElementScRsp>(() => new StartTimedFarmElementScRsp());

		// Token: 0x04005247 RID: 21063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005248 RID: 21064
		public const int BattleInfoFieldNumber = 2;

		// Token: 0x04005249 RID: 21065
		private SceneBattleInfo battleInfo_;

		// Token: 0x0400524A RID: 21066
		public const int WorldLevelFieldNumber = 1;

		// Token: 0x0400524B RID: 21067
		private uint worldLevel_;

		// Token: 0x0400524C RID: 21068
		public const int POLKBGLCBJDFieldNumber = 15;

		// Token: 0x0400524D RID: 21069
		private uint pOLKBGLCBJD_;

		// Token: 0x0400524E RID: 21070
		public const int RetcodeFieldNumber = 11;

		// Token: 0x0400524F RID: 21071
		private uint retcode_;
	}
}
