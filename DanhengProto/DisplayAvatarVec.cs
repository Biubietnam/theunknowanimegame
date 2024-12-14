using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003AF RID: 943
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DisplayAvatarVec : IMessage<DisplayAvatarVec>, IMessage, IEquatable<DisplayAvatarVec>, IDeepCloneable<DisplayAvatarVec>, IBufferMessage
	{
		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x00074B0D File Offset: 0x00072D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DisplayAvatarVec> Parser
		{
			get
			{
				return DisplayAvatarVec._parser;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x00074B14 File Offset: 0x00072D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DisplayAvatarVecReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x00074B26 File Offset: 0x00072D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisplayAvatarVec.Descriptor;
			}
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00074B2D File Offset: 0x00072D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarVec()
		{
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00074B40 File Offset: 0x00072D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarVec(DisplayAvatarVec other) : this()
		{
			this.displayAvatarList_ = other.displayAvatarList_.Clone();
			this.isDisplay_ = other.isDisplay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00074B76 File Offset: 0x00072D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarVec Clone()
		{
			return new DisplayAvatarVec(this);
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x00074B7E File Offset: 0x00072D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DisplayAvatarData> DisplayAvatarList
		{
			get
			{
				return this.displayAvatarList_;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x00074B86 File Offset: 0x00072D86
		// (set) Token: 0x060029F7 RID: 10743 RVA: 0x00074B8E File Offset: 0x00072D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDisplay
		{
			get
			{
				return this.isDisplay_;
			}
			set
			{
				this.isDisplay_ = value;
			}
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00074B97 File Offset: 0x00072D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DisplayAvatarVec);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00074BA8 File Offset: 0x00072DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DisplayAvatarVec other)
		{
			return other != null && (other == this || (this.displayAvatarList_.Equals(other.displayAvatarList_) && this.IsDisplay == other.IsDisplay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00074BF8 File Offset: 0x00072DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.displayAvatarList_.GetHashCode();
			if (this.IsDisplay)
			{
				num ^= this.IsDisplay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00074C45 File Offset: 0x00072E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00074C4D File Offset: 0x00072E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x00074C58 File Offset: 0x00072E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.displayAvatarList_.WriteTo(ref output, DisplayAvatarVec._repeated_displayAvatarList_codec);
			if (this.IsDisplay)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsDisplay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00074CA8 File Offset: 0x00072EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.displayAvatarList_.CalculateSize(DisplayAvatarVec._repeated_displayAvatarList_codec);
			if (this.IsDisplay)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00074CF0 File Offset: 0x00072EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DisplayAvatarVec other)
		{
			if (other == null)
			{
				return;
			}
			this.displayAvatarList_.Add(other.displayAvatarList_);
			if (other.IsDisplay)
			{
				this.IsDisplay = other.IsDisplay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00074D3D File Offset: 0x00072F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00074D48 File Offset: 0x00072F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsDisplay = input.ReadBool();
					}
				}
				else
				{
					this.displayAvatarList_.AddEntriesFrom(ref input, DisplayAvatarVec._repeated_displayAvatarList_codec);
				}
			}
		}

		// Token: 0x040010F1 RID: 4337
		private static readonly MessageParser<DisplayAvatarVec> _parser = new MessageParser<DisplayAvatarVec>(() => new DisplayAvatarVec());

		// Token: 0x040010F2 RID: 4338
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010F3 RID: 4339
		public const int DisplayAvatarListFieldNumber = 5;

		// Token: 0x040010F4 RID: 4340
		private static readonly FieldCodec<DisplayAvatarData> _repeated_displayAvatarList_codec = FieldCodec.ForMessage<DisplayAvatarData>(42U, DisplayAvatarData.Parser);

		// Token: 0x040010F5 RID: 4341
		private readonly RepeatedField<DisplayAvatarData> displayAvatarList_ = new RepeatedField<DisplayAvatarData>();

		// Token: 0x040010F6 RID: 4342
		public const int IsDisplayFieldNumber = 6;

		// Token: 0x040010F7 RID: 4343
		private bool isDisplay_;
	}
}
