using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A9 RID: 4521
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartCocoonStageCsReq : IMessage<StartCocoonStageCsReq>, IMessage, IEquatable<StartCocoonStageCsReq>, IDeepCloneable<StartCocoonStageCsReq>, IBufferMessage
	{
		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600C9D7 RID: 51671 RVA: 0x0021D6BD File Offset: 0x0021B8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartCocoonStageCsReq> Parser
		{
			get
			{
				return StartCocoonStageCsReq._parser;
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600C9D8 RID: 51672 RVA: 0x0021D6C4 File Offset: 0x0021B8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartCocoonStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600C9D9 RID: 51673 RVA: 0x0021D6D6 File Offset: 0x0021B8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartCocoonStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600C9DA RID: 51674 RVA: 0x0021D6DD File Offset: 0x0021B8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartCocoonStageCsReq()
		{
		}

		// Token: 0x0600C9DB RID: 51675 RVA: 0x0021D6E8 File Offset: 0x0021B8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartCocoonStageCsReq(StartCocoonStageCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this.cocoonId_ = other.cocoonId_;
			this.worldLevel_ = other.worldLevel_;
			this.wave_ = other.wave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9DC RID: 51676 RVA: 0x0021D73C File Offset: 0x0021B93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartCocoonStageCsReq Clone()
		{
			return new StartCocoonStageCsReq(this);
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600C9DD RID: 51677 RVA: 0x0021D744 File Offset: 0x0021B944
		// (set) Token: 0x0600C9DE RID: 51678 RVA: 0x0021D74C File Offset: 0x0021B94C
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

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600C9DF RID: 51679 RVA: 0x0021D755 File Offset: 0x0021B955
		// (set) Token: 0x0600C9E0 RID: 51680 RVA: 0x0021D75D File Offset: 0x0021B95D
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

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600C9E1 RID: 51681 RVA: 0x0021D766 File Offset: 0x0021B966
		// (set) Token: 0x0600C9E2 RID: 51682 RVA: 0x0021D76E File Offset: 0x0021B96E
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

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600C9E3 RID: 51683 RVA: 0x0021D777 File Offset: 0x0021B977
		// (set) Token: 0x0600C9E4 RID: 51684 RVA: 0x0021D77F File Offset: 0x0021B97F
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

		// Token: 0x0600C9E5 RID: 51685 RVA: 0x0021D788 File Offset: 0x0021B988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartCocoonStageCsReq);
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x0021D798 File Offset: 0x0021B998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartCocoonStageCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && this.CocoonId == other.CocoonId && this.WorldLevel == other.WorldLevel && this.Wave == other.Wave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9E7 RID: 51687 RVA: 0x0021D804 File Offset: 0x0021BA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this.CocoonId != 0U)
			{
				num ^= this.CocoonId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9E8 RID: 51688 RVA: 0x0021D88E File Offset: 0x0021BA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C9E9 RID: 51689 RVA: 0x0021D896 File Offset: 0x0021BA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9EA RID: 51690 RVA: 0x0021D8A0 File Offset: 0x0021BAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.CocoonId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.CocoonId);
			}
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Wave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9EB RID: 51691 RVA: 0x0021D934 File Offset: 0x0021BB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this.CocoonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CocoonId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9EC RID: 51692 RVA: 0x0021D9BC File Offset: 0x0021BBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartCocoonStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			if (other.CocoonId != 0U)
			{
				this.CocoonId = other.CocoonId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9ED RID: 51693 RVA: 0x0021DA34 File Offset: 0x0021BC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9EE RID: 51694 RVA: 0x0021DA40 File Offset: 0x0021BC40
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
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.CocoonId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.PropEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Wave = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005169 RID: 20841
		private static readonly MessageParser<StartCocoonStageCsReq> _parser = new MessageParser<StartCocoonStageCsReq>(() => new StartCocoonStageCsReq());

		// Token: 0x0400516A RID: 20842
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400516B RID: 20843
		public const int PropEntityIdFieldNumber = 8;

		// Token: 0x0400516C RID: 20844
		private uint propEntityId_;

		// Token: 0x0400516D RID: 20845
		public const int CocoonIdFieldNumber = 7;

		// Token: 0x0400516E RID: 20846
		private uint cocoonId_;

		// Token: 0x0400516F RID: 20847
		public const int WorldLevelFieldNumber = 4;

		// Token: 0x04005170 RID: 20848
		private uint worldLevel_;

		// Token: 0x04005171 RID: 20849
		public const int WaveFieldNumber = 9;

		// Token: 0x04005172 RID: 20850
		private uint wave_;
	}
}
