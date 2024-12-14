using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D3 RID: 467
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Chapter : IMessage<Chapter>, IMessage, IEquatable<Chapter>, IDeepCloneable<Chapter>, IBufferMessage
	{
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0003C041 File Offset: 0x0003A241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Chapter> Parser
		{
			get
			{
				return Chapter._parser;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0003C048 File Offset: 0x0003A248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChapterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x0003C05A File Offset: 0x0003A25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Chapter.Descriptor;
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0003C061 File Offset: 0x0003A261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Chapter()
		{
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0003C074 File Offset: 0x0003A274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Chapter(Chapter other) : this()
		{
			this.kAAGCNDCBAL_ = other.kAAGCNDCBAL_.Clone();
			this.kCPNIILMFEK_ = ((other.kCPNIILMFEK_ != null) ? other.kCPNIILMFEK_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0003C0C5 File Offset: 0x0003A2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Chapter Clone()
		{
			return new Chapter(this);
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0003C0CD File Offset: 0x0003A2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Waypoint> KAAGCNDCBAL
		{
			get
			{
				return this.kAAGCNDCBAL_;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0003C0D5 File Offset: 0x0003A2D5
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x0003C0DD File Offset: 0x0003A2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterBrief KCPNIILMFEK
		{
			get
			{
				return this.kCPNIILMFEK_;
			}
			set
			{
				this.kCPNIILMFEK_ = value;
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0003C0E6 File Offset: 0x0003A2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Chapter);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0003C0F4 File Offset: 0x0003A2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Chapter other)
		{
			return other != null && (other == this || (this.kAAGCNDCBAL_.Equals(other.kAAGCNDCBAL_) && object.Equals(this.KCPNIILMFEK, other.KCPNIILMFEK) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0003C148 File Offset: 0x0003A348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kAAGCNDCBAL_.GetHashCode();
			if (this.kCPNIILMFEK_ != null)
			{
				num ^= this.KCPNIILMFEK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0003C192 File Offset: 0x0003A392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0003C19A File Offset: 0x0003A39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0003C1A4 File Offset: 0x0003A3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kAAGCNDCBAL_.WriteTo(ref output, Chapter._repeated_kAAGCNDCBAL_codec);
			if (this.kCPNIILMFEK_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.KCPNIILMFEK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0003C1F4 File Offset: 0x0003A3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kAAGCNDCBAL_.CalculateSize(Chapter._repeated_kAAGCNDCBAL_codec);
			if (this.kCPNIILMFEK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KCPNIILMFEK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0003C248 File Offset: 0x0003A448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Chapter other)
		{
			if (other == null)
			{
				return;
			}
			this.kAAGCNDCBAL_.Add(other.kAAGCNDCBAL_);
			if (other.kCPNIILMFEK_ != null)
			{
				if (this.kCPNIILMFEK_ == null)
				{
					this.KCPNIILMFEK = new ChapterBrief();
				}
				this.KCPNIILMFEK.MergeFrom(other.KCPNIILMFEK);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0003C2AD File Offset: 0x0003A4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0003C2B8 File Offset: 0x0003A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.kCPNIILMFEK_ == null)
						{
							this.KCPNIILMFEK = new ChapterBrief();
						}
						input.ReadMessage(this.KCPNIILMFEK);
					}
				}
				else
				{
					this.kAAGCNDCBAL_.AddEntriesFrom(ref input, Chapter._repeated_kAAGCNDCBAL_codec);
				}
			}
		}

		// Token: 0x040008C5 RID: 2245
		private static readonly MessageParser<Chapter> _parser = new MessageParser<Chapter>(() => new Chapter());

		// Token: 0x040008C6 RID: 2246
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008C7 RID: 2247
		public const int KAAGCNDCBALFieldNumber = 6;

		// Token: 0x040008C8 RID: 2248
		private static readonly FieldCodec<Waypoint> _repeated_kAAGCNDCBAL_codec = FieldCodec.ForMessage<Waypoint>(50U, Waypoint.Parser);

		// Token: 0x040008C9 RID: 2249
		private readonly RepeatedField<Waypoint> kAAGCNDCBAL_ = new RepeatedField<Waypoint>();

		// Token: 0x040008CA RID: 2250
		public const int KCPNIILMFEKFieldNumber = 11;

		// Token: 0x040008CB RID: 2251
		private ChapterBrief kCPNIILMFEK_;
	}
}
