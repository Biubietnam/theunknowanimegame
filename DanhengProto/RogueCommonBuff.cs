using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E37 RID: 3639
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonBuff : IMessage<RogueCommonBuff>, IMessage, IEquatable<RogueCommonBuff>, IDeepCloneable<RogueCommonBuff>, IBufferMessage
	{
		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x0600A250 RID: 41552 RVA: 0x001B45FC File Offset: 0x001B27FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonBuff> Parser
		{
			get
			{
				return RogueCommonBuff._parser;
			}
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0600A251 RID: 41553 RVA: 0x001B4603 File Offset: 0x001B2803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonBuffReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0600A252 RID: 41554 RVA: 0x001B4615 File Offset: 0x001B2815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonBuff.Descriptor;
			}
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x001B461C File Offset: 0x001B281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuff()
		{
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x001B4624 File Offset: 0x001B2824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuff(RogueCommonBuff other) : this()
		{
			this.buffLevel_ = other.buffLevel_;
			this.buffId_ = other.buffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x001B4655 File Offset: 0x001B2855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuff Clone()
		{
			return new RogueCommonBuff(this);
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0600A256 RID: 41558 RVA: 0x001B465D File Offset: 0x001B285D
		// (set) Token: 0x0600A257 RID: 41559 RVA: 0x001B4665 File Offset: 0x001B2865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffLevel
		{
			get
			{
				return this.buffLevel_;
			}
			set
			{
				this.buffLevel_ = value;
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0600A258 RID: 41560 RVA: 0x001B466E File Offset: 0x001B286E
		// (set) Token: 0x0600A259 RID: 41561 RVA: 0x001B4676 File Offset: 0x001B2876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x001B467F File Offset: 0x001B287F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonBuff);
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x001B468D File Offset: 0x001B288D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonBuff other)
		{
			return other != null && (other == this || (this.BuffLevel == other.BuffLevel && this.BuffId == other.BuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x001B46CC File Offset: 0x001B28CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffLevel != 0U)
			{
				num ^= this.BuffLevel.GetHashCode();
			}
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x001B4724 File Offset: 0x001B2924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x001B472C File Offset: 0x001B292C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x001B4738 File Offset: 0x001B2938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffLevel != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BuffLevel);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x001B4794 File Offset: 0x001B2994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffLevel);
			}
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x001B47EC File Offset: 0x001B29EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffLevel != 0U)
			{
				this.BuffLevel = other.BuffLevel;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x001B483C File Offset: 0x001B2A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x001B4848 File Offset: 0x001B2A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BuffId = input.ReadUInt32();
					}
				}
				else
				{
					this.BuffLevel = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004271 RID: 17009
		private static readonly MessageParser<RogueCommonBuff> _parser = new MessageParser<RogueCommonBuff>(() => new RogueCommonBuff());

		// Token: 0x04004272 RID: 17010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004273 RID: 17011
		public const int BuffLevelFieldNumber = 5;

		// Token: 0x04004274 RID: 17012
		private uint buffLevel_;

		// Token: 0x04004275 RID: 17013
		public const int BuffIdFieldNumber = 6;

		// Token: 0x04004276 RID: 17014
		private uint buffId_;
	}
}
