using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200128B RID: 4747
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueCommonVirtualItemInfoScNotify : IMessage<SyncRogueCommonVirtualItemInfoScNotify>, IMessage, IEquatable<SyncRogueCommonVirtualItemInfoScNotify>, IDeepCloneable<SyncRogueCommonVirtualItemInfoScNotify>, IBufferMessage
	{
		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x0600D3CB RID: 54219 RVA: 0x00235A13 File Offset: 0x00233C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueCommonVirtualItemInfoScNotify> Parser
		{
			get
			{
				return SyncRogueCommonVirtualItemInfoScNotify._parser;
			}
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x0600D3CC RID: 54220 RVA: 0x00235A1A File Offset: 0x00233C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonVirtualItemInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x0600D3CD RID: 54221 RVA: 0x00235A2C File Offset: 0x00233C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueCommonVirtualItemInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600D3CE RID: 54222 RVA: 0x00235A33 File Offset: 0x00233C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonVirtualItemInfoScNotify()
		{
		}

		// Token: 0x0600D3CF RID: 54223 RVA: 0x00235A46 File Offset: 0x00233C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonVirtualItemInfoScNotify(SyncRogueCommonVirtualItemInfoScNotify other) : this()
		{
			this.commonItemInfo_ = other.commonItemInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3D0 RID: 54224 RVA: 0x00235A70 File Offset: 0x00233C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonVirtualItemInfoScNotify Clone()
		{
			return new SyncRogueCommonVirtualItemInfoScNotify(this);
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x0600D3D1 RID: 54225 RVA: 0x00235A78 File Offset: 0x00233C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonVirtualItemInfo> CommonItemInfo
		{
			get
			{
				return this.commonItemInfo_;
			}
		}

		// Token: 0x0600D3D2 RID: 54226 RVA: 0x00235A80 File Offset: 0x00233C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueCommonVirtualItemInfoScNotify);
		}

		// Token: 0x0600D3D3 RID: 54227 RVA: 0x00235A8E File Offset: 0x00233C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueCommonVirtualItemInfoScNotify other)
		{
			return other != null && (other == this || (this.commonItemInfo_.Equals(other.commonItemInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3D4 RID: 54228 RVA: 0x00235AC4 File Offset: 0x00233CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.commonItemInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D3D5 RID: 54229 RVA: 0x00235AF8 File Offset: 0x00233CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D3D6 RID: 54230 RVA: 0x00235B00 File Offset: 0x00233D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3D7 RID: 54231 RVA: 0x00235B09 File Offset: 0x00233D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.commonItemInfo_.WriteTo(ref output, SyncRogueCommonVirtualItemInfoScNotify._repeated_commonItemInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3D8 RID: 54232 RVA: 0x00235B30 File Offset: 0x00233D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.commonItemInfo_.CalculateSize(SyncRogueCommonVirtualItemInfoScNotify._repeated_commonItemInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x00235B69 File Offset: 0x00233D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueCommonVirtualItemInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.commonItemInfo_.Add(other.commonItemInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D3DA RID: 54234 RVA: 0x00235B97 File Offset: 0x00233D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3DB RID: 54235 RVA: 0x00235BA0 File Offset: 0x00233DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.commonItemInfo_.AddEntriesFrom(ref input, SyncRogueCommonVirtualItemInfoScNotify._repeated_commonItemInfo_codec);
				}
			}
		}

		// Token: 0x040054C7 RID: 21703
		private static readonly MessageParser<SyncRogueCommonVirtualItemInfoScNotify> _parser = new MessageParser<SyncRogueCommonVirtualItemInfoScNotify>(() => new SyncRogueCommonVirtualItemInfoScNotify());

		// Token: 0x040054C8 RID: 21704
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054C9 RID: 21705
		public const int CommonItemInfoFieldNumber = 12;

		// Token: 0x040054CA RID: 21706
		private static readonly FieldCodec<RogueCommonVirtualItemInfo> _repeated_commonItemInfo_codec = FieldCodec.ForMessage<RogueCommonVirtualItemInfo>(98U, RogueCommonVirtualItemInfo.Parser);

		// Token: 0x040054CB RID: 21707
		private readonly RepeatedField<RogueCommonVirtualItemInfo> commonItemInfo_ = new RepeatedField<RogueCommonVirtualItemInfo>();
	}
}
