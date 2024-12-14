using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011CD RID: 4557
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartTimedCocoonStageCsReq : IMessage<StartTimedCocoonStageCsReq>, IMessage, IEquatable<StartTimedCocoonStageCsReq>, IDeepCloneable<StartTimedCocoonStageCsReq>, IBufferMessage
	{
		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600CBA9 RID: 52137 RVA: 0x00222BF9 File Offset: 0x00220DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartTimedCocoonStageCsReq> Parser
		{
			get
			{
				return StartTimedCocoonStageCsReq._parser;
			}
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600CBAA RID: 52138 RVA: 0x00222C00 File Offset: 0x00220E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartTimedCocoonStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600CBAB RID: 52139 RVA: 0x00222C12 File Offset: 0x00220E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartTimedCocoonStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600CBAC RID: 52140 RVA: 0x00222C19 File Offset: 0x00220E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedCocoonStageCsReq()
		{
		}

		// Token: 0x0600CBAD RID: 52141 RVA: 0x00222C21 File Offset: 0x00220E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedCocoonStageCsReq(StartTimedCocoonStageCsReq other) : this()
		{
			this.cocoonId_ = other.cocoonId_;
			this.wave_ = other.wave_;
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBAE RID: 52142 RVA: 0x00222C5E File Offset: 0x00220E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedCocoonStageCsReq Clone()
		{
			return new StartTimedCocoonStageCsReq(this);
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600CBAF RID: 52143 RVA: 0x00222C66 File Offset: 0x00220E66
		// (set) Token: 0x0600CBB0 RID: 52144 RVA: 0x00222C6E File Offset: 0x00220E6E
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

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600CBB1 RID: 52145 RVA: 0x00222C77 File Offset: 0x00220E77
		// (set) Token: 0x0600CBB2 RID: 52146 RVA: 0x00222C7F File Offset: 0x00220E7F
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

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600CBB3 RID: 52147 RVA: 0x00222C88 File Offset: 0x00220E88
		// (set) Token: 0x0600CBB4 RID: 52148 RVA: 0x00222C90 File Offset: 0x00220E90
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

		// Token: 0x0600CBB5 RID: 52149 RVA: 0x00222C99 File Offset: 0x00220E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartTimedCocoonStageCsReq);
		}

		// Token: 0x0600CBB6 RID: 52150 RVA: 0x00222CA8 File Offset: 0x00220EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartTimedCocoonStageCsReq other)
		{
			return other != null && (other == this || (this.CocoonId == other.CocoonId && this.Wave == other.Wave && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBB7 RID: 52151 RVA: 0x00222D04 File Offset: 0x00220F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CocoonId != 0U)
			{
				num ^= this.CocoonId.GetHashCode();
			}
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBB8 RID: 52152 RVA: 0x00222D75 File Offset: 0x00220F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x00222D7D File Offset: 0x00220F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBBA RID: 52154 RVA: 0x00222D88 File Offset: 0x00220F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Wave);
			}
			if (this.CocoonId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CocoonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBBB RID: 52155 RVA: 0x00222E00 File Offset: 0x00221000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CocoonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CocoonId);
			}
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBBC RID: 52156 RVA: 0x00222E70 File Offset: 0x00221070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartTimedCocoonStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CocoonId != 0U)
			{
				this.CocoonId = other.CocoonId;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBBD RID: 52157 RVA: 0x00222ED4 File Offset: 0x002210D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBBE RID: 52158 RVA: 0x00222EE0 File Offset: 0x002210E0
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
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CocoonId = input.ReadUInt32();
						}
					}
					else
					{
						this.Wave = input.ReadUInt32();
					}
				}
				else
				{
					this.WorldLevel = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400522B RID: 21035
		private static readonly MessageParser<StartTimedCocoonStageCsReq> _parser = new MessageParser<StartTimedCocoonStageCsReq>(() => new StartTimedCocoonStageCsReq());

		// Token: 0x0400522C RID: 21036
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400522D RID: 21037
		public const int CocoonIdFieldNumber = 10;

		// Token: 0x0400522E RID: 21038
		private uint cocoonId_;

		// Token: 0x0400522F RID: 21039
		public const int WaveFieldNumber = 9;

		// Token: 0x04005230 RID: 21040
		private uint wave_;

		// Token: 0x04005231 RID: 21041
		public const int WorldLevelFieldNumber = 4;

		// Token: 0x04005232 RID: 21042
		private uint worldLevel_;
	}
}
