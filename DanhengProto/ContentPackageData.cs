using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000325 RID: 805
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContentPackageData : IMessage<ContentPackageData>, IMessage, IEquatable<ContentPackageData>, IDeepCloneable<ContentPackageData>, IBufferMessage
	{
		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x000667D3 File Offset: 0x000649D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContentPackageData> Parser
		{
			get
			{
				return ContentPackageData._parser;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x000667DA File Offset: 0x000649DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentPackageDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000667EC File Offset: 0x000649EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentPackageData.Descriptor;
			}
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x000667F3 File Offset: 0x000649F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageData()
		{
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00066806 File Offset: 0x00064A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageData(ContentPackageData other) : this()
		{
			this.curContentId_ = other.curContentId_;
			this.contentPackageList_ = other.contentPackageList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0006683C File Offset: 0x00064A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageData Clone()
		{
			return new ContentPackageData(this);
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x00066844 File Offset: 0x00064A44
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x0006684C File Offset: 0x00064A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurContentId
		{
			get
			{
				return this.curContentId_;
			}
			set
			{
				this.curContentId_ = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x00066855 File Offset: 0x00064A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ContentPackageInfo> ContentPackageList
		{
			get
			{
				return this.contentPackageList_;
			}
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0006685D File Offset: 0x00064A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentPackageData);
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0006686C File Offset: 0x00064A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContentPackageData other)
		{
			return other != null && (other == this || (this.CurContentId == other.CurContentId && this.contentPackageList_.Equals(other.contentPackageList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x000668BC File Offset: 0x00064ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurContentId != 0U)
			{
				num ^= this.CurContentId.GetHashCode();
			}
			num ^= this.contentPackageList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00066909 File Offset: 0x00064B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00066911 File Offset: 0x00064B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0006691C File Offset: 0x00064B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contentPackageList_.WriteTo(ref output, ContentPackageData._repeated_contentPackageList_codec);
			if (this.CurContentId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.CurContentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0006696C File Offset: 0x00064B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurContentId);
			}
			num += this.contentPackageList_.CalculateSize(ContentPackageData._repeated_contentPackageList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x000669C0 File Offset: 0x00064BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContentPackageData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurContentId != 0U)
			{
				this.CurContentId = other.CurContentId;
			}
			this.contentPackageList_.Add(other.contentPackageList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00066A0D File Offset: 0x00064C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00066A18 File Offset: 0x00064C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurContentId = input.ReadUInt32();
					}
				}
				else
				{
					this.contentPackageList_.AddEntriesFrom(ref input, ContentPackageData._repeated_contentPackageList_codec);
				}
			}
		}

		// Token: 0x04000ECC RID: 3788
		private static readonly MessageParser<ContentPackageData> _parser = new MessageParser<ContentPackageData>(() => new ContentPackageData());

		// Token: 0x04000ECD RID: 3789
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ECE RID: 3790
		public const int CurContentIdFieldNumber = 15;

		// Token: 0x04000ECF RID: 3791
		private uint curContentId_;

		// Token: 0x04000ED0 RID: 3792
		public const int ContentPackageListFieldNumber = 12;

		// Token: 0x04000ED1 RID: 3793
		private static readonly FieldCodec<ContentPackageInfo> _repeated_contentPackageList_codec = FieldCodec.ForMessage<ContentPackageInfo>(98U, ContentPackageInfo.Parser);

		// Token: 0x04000ED2 RID: 3794
		private readonly RepeatedField<ContentPackageInfo> contentPackageList_ = new RepeatedField<ContentPackageInfo>();
	}
}
