using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200006B RID: 107
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideTainerInfoScNotify : IMessage<AetherDivideTainerInfoScNotify>, IMessage, IEquatable<AetherDivideTainerInfoScNotify>, IDeepCloneable<AetherDivideTainerInfoScNotify>, IBufferMessage
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideTainerInfoScNotify> Parser
		{
			get
			{
				return AetherDivideTainerInfoScNotify._parser;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000D4CB File Offset: 0x0000B6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideTainerInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000D4DD File Offset: 0x0000B6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideTainerInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTainerInfoScNotify()
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTainerInfoScNotify(AetherDivideTainerInfoScNotify other) : this()
		{
			this.gOOHJJJOMEJ_ = other.gOOHJJJOMEJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000D511 File Offset: 0x0000B711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideTainerInfoScNotify Clone()
		{
			return new AetherDivideTainerInfoScNotify(this);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000D519 File Offset: 0x0000B719
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0000D521 File Offset: 0x0000B721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GOOHJJJOMEJ
		{
			get
			{
				return this.gOOHJJJOMEJ_;
			}
			set
			{
				this.gOOHJJJOMEJ_ = value;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000D52A File Offset: 0x0000B72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideTainerInfoScNotify);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000D538 File Offset: 0x0000B738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideTainerInfoScNotify other)
		{
			return other != null && (other == this || (this.GOOHJJJOMEJ == other.GOOHJJJOMEJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000D568 File Offset: 0x0000B768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GOOHJJJOMEJ != 0U)
			{
				num ^= this.GOOHJJJOMEJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000D5A7 File Offset: 0x0000B7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000D5AF File Offset: 0x0000B7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GOOHJJJOMEJ != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GOOHJJJOMEJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GOOHJJJOMEJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GOOHJJJOMEJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000D62A File Offset: 0x0000B82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideTainerInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GOOHJJJOMEJ != 0U)
			{
				this.GOOHJJJOMEJ = other.GOOHJJJOMEJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000D65B File Offset: 0x0000B85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000D664 File Offset: 0x0000B864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GOOHJJJOMEJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040001AB RID: 427
		private static readonly MessageParser<AetherDivideTainerInfoScNotify> _parser = new MessageParser<AetherDivideTainerInfoScNotify>(() => new AetherDivideTainerInfoScNotify());

		// Token: 0x040001AC RID: 428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001AD RID: 429
		public const int GOOHJJJOMEJFieldNumber = 15;

		// Token: 0x040001AE RID: 430
		private uint gOOHJJJOMEJ_;
	}
}
