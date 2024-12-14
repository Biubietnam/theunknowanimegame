using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E17 RID: 3607
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuff : IMessage<RogueBuff>, IMessage, IEquatable<RogueBuff>, IDeepCloneable<RogueBuff>, IBufferMessage
	{
		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x001AFFA4 File Offset: 0x001AE1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuff> Parser
		{
			get
			{
				return RogueBuff._parser;
			}
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0600A119 RID: 41241 RVA: 0x001AFFAB File Offset: 0x001AE1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x001AFFBD File Offset: 0x001AE1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuff.Descriptor;
			}
		}

		// Token: 0x0600A11B RID: 41243 RVA: 0x001AFFC4 File Offset: 0x001AE1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuff()
		{
		}

		// Token: 0x0600A11C RID: 41244 RVA: 0x001AFFCC File Offset: 0x001AE1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuff(RogueBuff other) : this()
		{
			this.buffId_ = other.buffId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A11D RID: 41245 RVA: 0x001AFFFD File Offset: 0x001AE1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuff Clone()
		{
			return new RogueBuff(this);
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600A11E RID: 41246 RVA: 0x001B0005 File Offset: 0x001AE205
		// (set) Token: 0x0600A11F RID: 41247 RVA: 0x001B000D File Offset: 0x001AE20D
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

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x001B0016 File Offset: 0x001AE216
		// (set) Token: 0x0600A121 RID: 41249 RVA: 0x001B001E File Offset: 0x001AE21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x001B0027 File Offset: 0x001AE227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuff);
		}

		// Token: 0x0600A123 RID: 41251 RVA: 0x001B0035 File Offset: 0x001AE235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuff other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A124 RID: 41252 RVA: 0x001B0074 File Offset: 0x001AE274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A125 RID: 41253 RVA: 0x001B00CC File Offset: 0x001AE2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A126 RID: 41254 RVA: 0x001B00D4 File Offset: 0x001AE2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A127 RID: 41255 RVA: 0x001B00E0 File Offset: 0x001AE2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Level);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x001B013C File Offset: 0x001AE33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A129 RID: 41257 RVA: 0x001B0194 File Offset: 0x001AE394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x001B01E4 File Offset: 0x001AE3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x001B01F0 File Offset: 0x001AE3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 120U)
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
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040041F6 RID: 16886
		private static readonly MessageParser<RogueBuff> _parser = new MessageParser<RogueBuff>(() => new RogueBuff());

		// Token: 0x040041F7 RID: 16887
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041F8 RID: 16888
		public const int BuffIdFieldNumber = 15;

		// Token: 0x040041F9 RID: 16889
		private uint buffId_;

		// Token: 0x040041FA RID: 16890
		public const int LevelFieldNumber = 9;

		// Token: 0x040041FB RID: 16891
		private uint level_;
	}
}
