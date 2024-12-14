using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E09 RID: 3593
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAreaInfo : IMessage<RogueAreaInfo>, IMessage, IEquatable<RogueAreaInfo>, IDeepCloneable<RogueAreaInfo>, IBufferMessage
	{
		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x0600A0AF RID: 41135 RVA: 0x001AF300 File Offset: 0x001AD500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAreaInfo> Parser
		{
			get
			{
				return RogueAreaInfo._parser;
			}
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x0600A0B0 RID: 41136 RVA: 0x001AF307 File Offset: 0x001AD507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAreaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x0600A0B1 RID: 41137 RVA: 0x001AF319 File Offset: 0x001AD519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x001AF320 File Offset: 0x001AD520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAreaInfo()
		{
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x001AF333 File Offset: 0x001AD533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAreaInfo(RogueAreaInfo other) : this()
		{
			this.rogueAreaList_ = other.rogueAreaList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0B4 RID: 41140 RVA: 0x001AF35D File Offset: 0x001AD55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAreaInfo Clone()
		{
			return new RogueAreaInfo(this);
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0600A0B5 RID: 41141 RVA: 0x001AF365 File Offset: 0x001AD565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueArea> RogueAreaList
		{
			get
			{
				return this.rogueAreaList_;
			}
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x001AF36D File Offset: 0x001AD56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAreaInfo);
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x001AF37B File Offset: 0x001AD57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAreaInfo other)
		{
			return other != null && (other == this || (this.rogueAreaList_.Equals(other.rogueAreaList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x001AF3B0 File Offset: 0x001AD5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueAreaList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0B9 RID: 41145 RVA: 0x001AF3E4 File Offset: 0x001AD5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0BA RID: 41146 RVA: 0x001AF3EC File Offset: 0x001AD5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0BB RID: 41147 RVA: 0x001AF3F5 File Offset: 0x001AD5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueAreaList_.WriteTo(ref output, RogueAreaInfo._repeated_rogueAreaList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0BC RID: 41148 RVA: 0x001AF41C File Offset: 0x001AD61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueAreaList_.CalculateSize(RogueAreaInfo._repeated_rogueAreaList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0BD RID: 41149 RVA: 0x001AF455 File Offset: 0x001AD655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueAreaList_.Add(other.rogueAreaList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x001AF483 File Offset: 0x001AD683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x001AF48C File Offset: 0x001AD68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueAreaList_.AddEntriesFrom(ref input, RogueAreaInfo._repeated_rogueAreaList_codec);
				}
			}
		}

		// Token: 0x040041D2 RID: 16850
		private static readonly MessageParser<RogueAreaInfo> _parser = new MessageParser<RogueAreaInfo>(() => new RogueAreaInfo());

		// Token: 0x040041D3 RID: 16851
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041D4 RID: 16852
		public const int RogueAreaListFieldNumber = 6;

		// Token: 0x040041D5 RID: 16853
		private static readonly FieldCodec<RogueArea> _repeated_rogueAreaList_codec = FieldCodec.ForMessage<RogueArea>(50U, RogueArea.Parser);

		// Token: 0x040041D6 RID: 16854
		private readonly RepeatedField<RogueArea> rogueAreaList_ = new RepeatedField<RogueArea>();
	}
}
