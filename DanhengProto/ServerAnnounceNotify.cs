using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010BF RID: 4287
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerAnnounceNotify : IMessage<ServerAnnounceNotify>, IMessage, IEquatable<ServerAnnounceNotify>, IDeepCloneable<ServerAnnounceNotify>, IBufferMessage
	{
		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600BF31 RID: 48945 RVA: 0x00202FD1 File Offset: 0x002011D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServerAnnounceNotify> Parser
		{
			get
			{
				return ServerAnnounceNotify._parser;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600BF32 RID: 48946 RVA: 0x00202FD8 File Offset: 0x002011D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerAnnounceNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600BF33 RID: 48947 RVA: 0x00202FEA File Offset: 0x002011EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerAnnounceNotify.Descriptor;
			}
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x00202FF1 File Offset: 0x002011F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerAnnounceNotify()
		{
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x00203004 File Offset: 0x00201204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerAnnounceNotify(ServerAnnounceNotify other) : this()
		{
			this.announceDataList_ = other.announceDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF36 RID: 48950 RVA: 0x0020302E File Offset: 0x0020122E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerAnnounceNotify Clone()
		{
			return new ServerAnnounceNotify(this);
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600BF37 RID: 48951 RVA: 0x00203036 File Offset: 0x00201236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AnnounceData> AnnounceDataList
		{
			get
			{
				return this.announceDataList_;
			}
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x0020303E File Offset: 0x0020123E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerAnnounceNotify);
		}

		// Token: 0x0600BF39 RID: 48953 RVA: 0x0020304C File Offset: 0x0020124C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServerAnnounceNotify other)
		{
			return other != null && (other == this || (this.announceDataList_.Equals(other.announceDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF3A RID: 48954 RVA: 0x00203080 File Offset: 0x00201280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.announceDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x002030B4 File Offset: 0x002012B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x002030BC File Offset: 0x002012BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF3D RID: 48957 RVA: 0x002030C5 File Offset: 0x002012C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.announceDataList_.WriteTo(ref output, ServerAnnounceNotify._repeated_announceDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF3E RID: 48958 RVA: 0x002030EC File Offset: 0x002012EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.announceDataList_.CalculateSize(ServerAnnounceNotify._repeated_announceDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF3F RID: 48959 RVA: 0x00203125 File Offset: 0x00201325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServerAnnounceNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.announceDataList_.Add(other.announceDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF40 RID: 48960 RVA: 0x00203153 File Offset: 0x00201353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF41 RID: 48961 RVA: 0x0020315C File Offset: 0x0020135C
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
					this.announceDataList_.AddEntriesFrom(ref input, ServerAnnounceNotify._repeated_announceDataList_codec);
				}
			}
		}

		// Token: 0x04004DA8 RID: 19880
		private static readonly MessageParser<ServerAnnounceNotify> _parser = new MessageParser<ServerAnnounceNotify>(() => new ServerAnnounceNotify());

		// Token: 0x04004DA9 RID: 19881
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DAA RID: 19882
		public const int AnnounceDataListFieldNumber = 6;

		// Token: 0x04004DAB RID: 19883
		private static readonly FieldCodec<AnnounceData> _repeated_announceDataList_codec = FieldCodec.ForMessage<AnnounceData>(50U, AnnounceData.Parser);

		// Token: 0x04004DAC RID: 19884
		private readonly RepeatedField<AnnounceData> announceDataList_ = new RepeatedField<AnnounceData>();
	}
}
