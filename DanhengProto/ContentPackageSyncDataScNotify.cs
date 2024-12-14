using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200032F RID: 815
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContentPackageSyncDataScNotify : IMessage<ContentPackageSyncDataScNotify>, IMessage, IEquatable<ContentPackageSyncDataScNotify>, IDeepCloneable<ContentPackageSyncDataScNotify>, IBufferMessage
	{
		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x00067441 File Offset: 0x00065641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContentPackageSyncDataScNotify> Parser
		{
			get
			{
				return ContentPackageSyncDataScNotify._parser;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x00067448 File Offset: 0x00065648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentPackageSyncDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x0006745A File Offset: 0x0006565A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentPackageSyncDataScNotify.Descriptor;
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00067461 File Offset: 0x00065661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageSyncDataScNotify()
		{
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00067469 File Offset: 0x00065669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageSyncDataScNotify(ContentPackageSyncDataScNotify other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0006749E File Offset: 0x0006569E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageSyncDataScNotify Clone()
		{
			return new ContentPackageSyncDataScNotify(this);
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x000674A6 File Offset: 0x000656A6
		// (set) Token: 0x0600247B RID: 9339 RVA: 0x000674AE File Offset: 0x000656AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageData Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000674B7 File Offset: 0x000656B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentPackageSyncDataScNotify);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x000674C5 File Offset: 0x000656C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContentPackageSyncDataScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000674F8 File Offset: 0x000656F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00067534 File Offset: 0x00065734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0006753C File Offset: 0x0006573C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00067545 File Offset: 0x00065745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00067578 File Offset: 0x00065778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x000675B8 File Offset: 0x000657B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContentPackageSyncDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new ContentPackageData();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0006760C File Offset: 0x0006580C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00067618 File Offset: 0x00065818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.data_ == null)
					{
						this.Data = new ContentPackageData();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x04000EEC RID: 3820
		private static readonly MessageParser<ContentPackageSyncDataScNotify> _parser = new MessageParser<ContentPackageSyncDataScNotify>(() => new ContentPackageSyncDataScNotify());

		// Token: 0x04000EED RID: 3821
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EEE RID: 3822
		public const int DataFieldNumber = 1;

		// Token: 0x04000EEF RID: 3823
		private ContentPackageData data_;
	}
}
