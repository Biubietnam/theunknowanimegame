using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009B1 RID: 2481
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KilledPunkLordMonsterInfo : IMessage<KilledPunkLordMonsterInfo>, IMessage, IEquatable<KilledPunkLordMonsterInfo>, IDeepCloneable<KilledPunkLordMonsterInfo>, IBufferMessage
	{
		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06006ED8 RID: 28376 RVA: 0x001280B7 File Offset: 0x001262B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KilledPunkLordMonsterInfo> Parser
		{
			get
			{
				return KilledPunkLordMonsterInfo._parser;
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06006ED9 RID: 28377 RVA: 0x001280BE File Offset: 0x001262BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KilledPunkLordMonsterInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06006EDA RID: 28378 RVA: 0x001280D0 File Offset: 0x001262D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KilledPunkLordMonsterInfo.Descriptor;
			}
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x001280D7 File Offset: 0x001262D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KilledPunkLordMonsterInfo()
		{
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x001280E0 File Offset: 0x001262E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KilledPunkLordMonsterInfo(KilledPunkLordMonsterInfo other) : this()
		{
			this.oEFFLBFHCCA_ = other.oEFFLBFHCCA_;
			this.configId_ = other.configId_;
			this.monsterId_ = other.monsterId_;
			this.createTime_ = other.createTime_;
			this.worldLevel_ = other.worldLevel_;
			this.mMBAOCGFBLI_ = other.mMBAOCGFBLI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x0012814C File Offset: 0x0012634C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KilledPunkLordMonsterInfo Clone()
		{
			return new KilledPunkLordMonsterInfo(this);
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x00128154 File Offset: 0x00126354
		// (set) Token: 0x06006EDF RID: 28383 RVA: 0x0012815C File Offset: 0x0012635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OEFFLBFHCCA
		{
			get
			{
				return this.oEFFLBFHCCA_;
			}
			set
			{
				this.oEFFLBFHCCA_ = value;
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x00128165 File Offset: 0x00126365
		// (set) Token: 0x06006EE1 RID: 28385 RVA: 0x0012816D File Offset: 0x0012636D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x06006EE2 RID: 28386 RVA: 0x00128176 File Offset: 0x00126376
		// (set) Token: 0x06006EE3 RID: 28387 RVA: 0x0012817E File Offset: 0x0012637E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x06006EE4 RID: 28388 RVA: 0x00128187 File Offset: 0x00126387
		// (set) Token: 0x06006EE5 RID: 28389 RVA: 0x0012818F File Offset: 0x0012638F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06006EE6 RID: 28390 RVA: 0x00128198 File Offset: 0x00126398
		// (set) Token: 0x06006EE7 RID: 28391 RVA: 0x001281A0 File Offset: 0x001263A0
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

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06006EE8 RID: 28392 RVA: 0x001281A9 File Offset: 0x001263A9
		// (set) Token: 0x06006EE9 RID: 28393 RVA: 0x001281B1 File Offset: 0x001263B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MMBAOCGFBLI
		{
			get
			{
				return this.mMBAOCGFBLI_;
			}
			set
			{
				this.mMBAOCGFBLI_ = value;
			}
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x001281BA File Offset: 0x001263BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KilledPunkLordMonsterInfo);
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x001281C8 File Offset: 0x001263C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KilledPunkLordMonsterInfo other)
		{
			return other != null && (other == this || (this.OEFFLBFHCCA == other.OEFFLBFHCCA && this.ConfigId == other.ConfigId && this.MonsterId == other.MonsterId && this.CreateTime == other.CreateTime && this.WorldLevel == other.WorldLevel && this.MMBAOCGFBLI == other.MMBAOCGFBLI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x00128254 File Offset: 0x00126454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OEFFLBFHCCA != 0U)
			{
				num ^= this.OEFFLBFHCCA.GetHashCode();
			}
			if (this.ConfigId != 0U)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.CreateTime != 0L)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.MMBAOCGFBLI)
			{
				num ^= this.MMBAOCGFBLI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x00128310 File Offset: 0x00126510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x00128318 File Offset: 0x00126518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x00128324 File Offset: 0x00126524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ConfigId);
			}
			if (this.MMBAOCGFBLI)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.MMBAOCGFBLI);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.CreateTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.CreateTime);
			}
			if (this.OEFFLBFHCCA != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.OEFFLBFHCCA);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x001283F0 File Offset: 0x001265F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OEFFLBFHCCA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OEFFLBFHCCA);
			}
			if (this.ConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConfigId);
			}
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.CreateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreateTime);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.MMBAOCGFBLI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x0012849C File Offset: 0x0012669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KilledPunkLordMonsterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OEFFLBFHCCA != 0U)
			{
				this.OEFFLBFHCCA = other.OEFFLBFHCCA;
			}
			if (other.ConfigId != 0U)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.CreateTime != 0L)
			{
				this.CreateTime = other.CreateTime;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.MMBAOCGFBLI)
			{
				this.MMBAOCGFBLI = other.MMBAOCGFBLI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x0012853C File Offset: 0x0012673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x00128548 File Offset: 0x00126748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.ConfigId = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.MMBAOCGFBLI = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.CreateTime = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.OEFFLBFHCCA = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.MonsterId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A93 RID: 10899
		private static readonly MessageParser<KilledPunkLordMonsterInfo> _parser = new MessageParser<KilledPunkLordMonsterInfo>(() => new KilledPunkLordMonsterInfo());

		// Token: 0x04002A94 RID: 10900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A95 RID: 10901
		public const int OEFFLBFHCCAFieldNumber = 13;

		// Token: 0x04002A96 RID: 10902
		private uint oEFFLBFHCCA_;

		// Token: 0x04002A97 RID: 10903
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x04002A98 RID: 10904
		private uint configId_;

		// Token: 0x04002A99 RID: 10905
		public const int MonsterIdFieldNumber = 15;

		// Token: 0x04002A9A RID: 10906
		private uint monsterId_;

		// Token: 0x04002A9B RID: 10907
		public const int CreateTimeFieldNumber = 9;

		// Token: 0x04002A9C RID: 10908
		private long createTime_;

		// Token: 0x04002A9D RID: 10909
		public const int WorldLevelFieldNumber = 6;

		// Token: 0x04002A9E RID: 10910
		private uint worldLevel_;

		// Token: 0x04002A9F RID: 10911
		public const int MMBAOCGFBLIFieldNumber = 5;

		// Token: 0x04002AA0 RID: 10912
		private bool mMBAOCGFBLI_;
	}
}
