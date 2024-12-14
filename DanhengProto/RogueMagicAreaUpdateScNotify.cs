using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EAD RID: 3757
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicAreaUpdateScNotify : IMessage<RogueMagicAreaUpdateScNotify>, IMessage, IEquatable<RogueMagicAreaUpdateScNotify>, IDeepCloneable<RogueMagicAreaUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x0600A7E2 RID: 42978 RVA: 0x001C4553 File Offset: 0x001C2753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicAreaUpdateScNotify> Parser
		{
			get
			{
				return RogueMagicAreaUpdateScNotify._parser;
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x001C455A File Offset: 0x001C275A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicAreaUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x0600A7E4 RID: 42980 RVA: 0x001C456C File Offset: 0x001C276C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicAreaUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x001C4573 File Offset: 0x001C2773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAreaUpdateScNotify()
		{
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x001C4586 File Offset: 0x001C2786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAreaUpdateScNotify(RogueMagicAreaUpdateScNotify other) : this()
		{
			this.rogueTournAreaInfo_ = other.rogueTournAreaInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x001C45B0 File Offset: 0x001C27B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAreaUpdateScNotify Clone()
		{
			return new RogueMagicAreaUpdateScNotify(this);
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x0600A7E8 RID: 42984 RVA: 0x001C45B8 File Offset: 0x001C27B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicAreaInfo> RogueTournAreaInfo
		{
			get
			{
				return this.rogueTournAreaInfo_;
			}
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x001C45C0 File Offset: 0x001C27C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicAreaUpdateScNotify);
		}

		// Token: 0x0600A7EA RID: 42986 RVA: 0x001C45CE File Offset: 0x001C27CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicAreaUpdateScNotify other)
		{
			return other != null && (other == this || (this.rogueTournAreaInfo_.Equals(other.rogueTournAreaInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x001C4604 File Offset: 0x001C2804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueTournAreaInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x001C4638 File Offset: 0x001C2838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x001C4640 File Offset: 0x001C2840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7EE RID: 42990 RVA: 0x001C4649 File Offset: 0x001C2849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueTournAreaInfo_.WriteTo(ref output, RogueMagicAreaUpdateScNotify._repeated_rogueTournAreaInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7EF RID: 42991 RVA: 0x001C4670 File Offset: 0x001C2870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueTournAreaInfo_.CalculateSize(RogueMagicAreaUpdateScNotify._repeated_rogueTournAreaInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x001C46A9 File Offset: 0x001C28A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicAreaUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueTournAreaInfo_.Add(other.rogueTournAreaInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x001C46D7 File Offset: 0x001C28D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x001C46E0 File Offset: 0x001C28E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueTournAreaInfo_.AddEntriesFrom(ref input, RogueMagicAreaUpdateScNotify._repeated_rogueTournAreaInfo_codec);
				}
			}
		}

		// Token: 0x040044A9 RID: 17577
		private static readonly MessageParser<RogueMagicAreaUpdateScNotify> _parser = new MessageParser<RogueMagicAreaUpdateScNotify>(() => new RogueMagicAreaUpdateScNotify());

		// Token: 0x040044AA RID: 17578
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044AB RID: 17579
		public const int RogueTournAreaInfoFieldNumber = 14;

		// Token: 0x040044AC RID: 17580
		private static readonly FieldCodec<RogueMagicAreaInfo> _repeated_rogueTournAreaInfo_codec = FieldCodec.ForMessage<RogueMagicAreaInfo>(114U, RogueMagicAreaInfo.Parser);

		// Token: 0x040044AD RID: 17581
		private readonly RepeatedField<RogueMagicAreaInfo> rogueTournAreaInfo_ = new RepeatedField<RogueMagicAreaInfo>();
	}
}
