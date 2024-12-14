using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000761 RID: 1889
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlatformPlayerInfoCsReq : IMessage<GetPlatformPlayerInfoCsReq>, IMessage, IEquatable<GetPlatformPlayerInfoCsReq>, IDeepCloneable<GetPlatformPlayerInfoCsReq>, IBufferMessage
	{
		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06005469 RID: 21609 RVA: 0x000E3039 File Offset: 0x000E1239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlatformPlayerInfoCsReq> Parser
		{
			get
			{
				return GetPlatformPlayerInfoCsReq._parser;
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x000E3040 File Offset: 0x000E1240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlatformPlayerInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x0600546B RID: 21611 RVA: 0x000E3052 File Offset: 0x000E1252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlatformPlayerInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x000E3059 File Offset: 0x000E1259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlatformPlayerInfoCsReq()
		{
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x000E306C File Offset: 0x000E126C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlatformPlayerInfoCsReq(GetPlatformPlayerInfoCsReq other) : this()
		{
			this.platform_ = other.platform_;
			this.eEOFFDDMGIB_ = other.eEOFFDDMGIB_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x000E30A2 File Offset: 0x000E12A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlatformPlayerInfoCsReq Clone()
		{
			return new GetPlatformPlayerInfoCsReq(this);
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x0600546F RID: 21615 RVA: 0x000E30AA File Offset: 0x000E12AA
		// (set) Token: 0x06005470 RID: 21616 RVA: 0x000E30B2 File Offset: 0x000E12B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlatformType Platform
		{
			get
			{
				return this.platform_;
			}
			set
			{
				this.platform_ = value;
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06005471 RID: 21617 RVA: 0x000E30BB File Offset: 0x000E12BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> EEOFFDDMGIB
		{
			get
			{
				return this.eEOFFDDMGIB_;
			}
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x000E30C3 File Offset: 0x000E12C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlatformPlayerInfoCsReq);
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x000E30D4 File Offset: 0x000E12D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlatformPlayerInfoCsReq other)
		{
			return other != null && (other == this || (this.Platform == other.Platform && this.eEOFFDDMGIB_.Equals(other.eEOFFDDMGIB_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x000E3124 File Offset: 0x000E1324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Platform != PlatformType.Editor)
			{
				num ^= this.Platform.GetHashCode();
			}
			num ^= this.eEOFFDDMGIB_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x000E3177 File Offset: 0x000E1377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x000E317F File Offset: 0x000E137F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x000E3188 File Offset: 0x000E1388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.eEOFFDDMGIB_.WriteTo(ref output, GetPlatformPlayerInfoCsReq._repeated_eEOFFDDMGIB_codec);
			if (this.Platform != PlatformType.Editor)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Platform);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x000E31D8 File Offset: 0x000E13D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Platform != PlatformType.Editor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Platform);
			}
			num += this.eEOFFDDMGIB_.CalculateSize(GetPlatformPlayerInfoCsReq._repeated_eEOFFDDMGIB_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x000E322C File Offset: 0x000E142C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlatformPlayerInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Platform != PlatformType.Editor)
			{
				this.Platform = other.Platform;
			}
			this.eEOFFDDMGIB_.Add(other.eEOFFDDMGIB_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x000E3279 File Offset: 0x000E1479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x000E3284 File Offset: 0x000E1484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Platform = (PlatformType)input.ReadEnum();
					}
				}
				else
				{
					this.eEOFFDDMGIB_.AddEntriesFrom(ref input, GetPlatformPlayerInfoCsReq._repeated_eEOFFDDMGIB_codec);
				}
			}
		}

		// Token: 0x04002125 RID: 8485
		private static readonly MessageParser<GetPlatformPlayerInfoCsReq> _parser = new MessageParser<GetPlatformPlayerInfoCsReq>(() => new GetPlatformPlayerInfoCsReq());

		// Token: 0x04002126 RID: 8486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002127 RID: 8487
		public const int PlatformFieldNumber = 4;

		// Token: 0x04002128 RID: 8488
		private PlatformType platform_;

		// Token: 0x04002129 RID: 8489
		public const int EEOFFDDMGIBFieldNumber = 1;

		// Token: 0x0400212A RID: 8490
		private static readonly FieldCodec<string> _repeated_eEOFFDDMGIB_codec = FieldCodec.ForString(10U);

		// Token: 0x0400212B RID: 8491
		private readonly RepeatedField<string> eEOFFDDMGIB_ = new RepeatedField<string>();
	}
}
