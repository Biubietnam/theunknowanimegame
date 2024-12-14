using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200068D RID: 1677
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetEnteredSceneScRsp : IMessage<GetEnteredSceneScRsp>, IMessage, IEquatable<GetEnteredSceneScRsp>, IDeepCloneable<GetEnteredSceneScRsp>, IBufferMessage
	{
		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x000CC3D3 File Offset: 0x000CA5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetEnteredSceneScRsp> Parser
		{
			get
			{
				return GetEnteredSceneScRsp._parser;
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06004B1F RID: 19231 RVA: 0x000CC3DA File Offset: 0x000CA5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetEnteredSceneScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x000CC3EC File Offset: 0x000CA5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetEnteredSceneScRsp.Descriptor;
			}
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x000CC3F3 File Offset: 0x000CA5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnteredSceneScRsp()
		{
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x000CC406 File Offset: 0x000CA606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnteredSceneScRsp(GetEnteredSceneScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.enteredSceneInfoList_ = other.enteredSceneInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x000CC43C File Offset: 0x000CA63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnteredSceneScRsp Clone()
		{
			return new GetEnteredSceneScRsp(this);
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x000CC444 File Offset: 0x000CA644
		// (set) Token: 0x06004B25 RID: 19237 RVA: 0x000CC44C File Offset: 0x000CA64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x000CC455 File Offset: 0x000CA655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnteredSceneInfo> EnteredSceneInfoList
		{
			get
			{
				return this.enteredSceneInfoList_;
			}
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x000CC45D File Offset: 0x000CA65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetEnteredSceneScRsp);
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x000CC46C File Offset: 0x000CA66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetEnteredSceneScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.enteredSceneInfoList_.Equals(other.enteredSceneInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x000CC4BC File Offset: 0x000CA6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.enteredSceneInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x000CC509 File Offset: 0x000CA709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x000CC511 File Offset: 0x000CA711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x000CC51C File Offset: 0x000CA71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.enteredSceneInfoList_.WriteTo(ref output, GetEnteredSceneScRsp._repeated_enteredSceneInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x000CC56C File Offset: 0x000CA76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.enteredSceneInfoList_.CalculateSize(GetEnteredSceneScRsp._repeated_enteredSceneInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x000CC5C0 File Offset: 0x000CA7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetEnteredSceneScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.enteredSceneInfoList_.Add(other.enteredSceneInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x000CC60D File Offset: 0x000CA80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x000CC618 File Offset: 0x000CA818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.enteredSceneInfoList_.AddEntriesFrom(ref input, GetEnteredSceneScRsp._repeated_enteredSceneInfoList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001DC8 RID: 7624
		private static readonly MessageParser<GetEnteredSceneScRsp> _parser = new MessageParser<GetEnteredSceneScRsp>(() => new GetEnteredSceneScRsp());

		// Token: 0x04001DC9 RID: 7625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DCA RID: 7626
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04001DCB RID: 7627
		private uint retcode_;

		// Token: 0x04001DCC RID: 7628
		public const int EnteredSceneInfoListFieldNumber = 14;

		// Token: 0x04001DCD RID: 7629
		private static readonly FieldCodec<EnteredSceneInfo> _repeated_enteredSceneInfoList_codec = FieldCodec.ForMessage<EnteredSceneInfo>(114U, EnteredSceneInfo.Parser);

		// Token: 0x04001DCE RID: 7630
		private readonly RepeatedField<EnteredSceneInfo> enteredSceneInfoList_ = new RepeatedField<EnteredSceneInfo>();
	}
}
