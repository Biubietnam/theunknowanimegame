using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C1 RID: 193
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AvatarExpUpScRsp : IMessage<AvatarExpUpScRsp>, IMessage, IEquatable<AvatarExpUpScRsp>, IDeepCloneable<AvatarExpUpScRsp>, IBufferMessage
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00019DB1 File Offset: 0x00017FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarExpUpScRsp> Parser
		{
			get
			{
				return AvatarExpUpScRsp._parser;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00019DB8 File Offset: 0x00017FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarExpUpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00019DCA File Offset: 0x00017FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarExpUpScRsp.Descriptor;
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00019DD1 File Offset: 0x00017FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarExpUpScRsp()
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00019DE4 File Offset: 0x00017FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarExpUpScRsp(AvatarExpUpScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.returnItemList_ = other.returnItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00019E1A File Offset: 0x0001801A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarExpUpScRsp Clone()
		{
			return new AvatarExpUpScRsp(this);
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00019E22 File Offset: 0x00018022
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00019E2A File Offset: 0x0001802A
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00019E33 File Offset: 0x00018033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PileItem> ReturnItemList
		{
			get
			{
				return this.returnItemList_;
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00019E3B File Offset: 0x0001803B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarExpUpScRsp);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00019E4C File Offset: 0x0001804C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarExpUpScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.returnItemList_.Equals(other.returnItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00019E9C File Offset: 0x0001809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.returnItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00019EE9 File Offset: 0x000180E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00019EF1 File Offset: 0x000180F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00019EFC File Offset: 0x000180FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			this.returnItemList_.WriteTo(ref output, AvatarExpUpScRsp._repeated_returnItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00019F4C File Offset: 0x0001814C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.returnItemList_.CalculateSize(AvatarExpUpScRsp._repeated_returnItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00019FA0 File Offset: 0x000181A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarExpUpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.returnItemList_.Add(other.returnItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00019FED File Offset: 0x000181ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00019FF8 File Offset: 0x000181F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.returnItemList_.AddEntriesFrom(ref input, AvatarExpUpScRsp._repeated_returnItemList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400038C RID: 908
		private static readonly MessageParser<AvatarExpUpScRsp> _parser = new MessageParser<AvatarExpUpScRsp>(() => new AvatarExpUpScRsp());

		// Token: 0x0400038D RID: 909
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400038E RID: 910
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400038F RID: 911
		private uint retcode_;

		// Token: 0x04000390 RID: 912
		public const int ReturnItemListFieldNumber = 10;

		// Token: 0x04000391 RID: 913
		private static readonly FieldCodec<PileItem> _repeated_returnItemList_codec = FieldCodec.ForMessage<PileItem>(82U, PileItem.Parser);

		// Token: 0x04000392 RID: 914
		private readonly RepeatedField<PileItem> returnItemList_ = new RepeatedField<PileItem>();
	}
}
