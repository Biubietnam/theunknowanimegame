using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000331 RID: 817
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContentPackageTransferScNotify : IMessage<ContentPackageTransferScNotify>, IMessage, IEquatable<ContentPackageTransferScNotify>, IDeepCloneable<ContentPackageTransferScNotify>, IBufferMessage
	{
		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000676EB File Offset: 0x000658EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContentPackageTransferScNotify> Parser
		{
			get
			{
				return ContentPackageTransferScNotify._parser;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000676F2 File Offset: 0x000658F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentPackageTransferScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x00067704 File Offset: 0x00065904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentPackageTransferScNotify.Descriptor;
			}
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0006770B File Offset: 0x0006590B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageTransferScNotify()
		{
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00067713 File Offset: 0x00065913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageTransferScNotify(ContentPackageTransferScNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0006772C File Offset: 0x0006592C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageTransferScNotify Clone()
		{
			return new ContentPackageTransferScNotify(this);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00067734 File Offset: 0x00065934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentPackageTransferScNotify);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00067742 File Offset: 0x00065942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContentPackageTransferScNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00067760 File Offset: 0x00065960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00067786 File Offset: 0x00065986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0006778E File Offset: 0x0006598E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00067797 File Offset: 0x00065997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x000677B0 File Offset: 0x000659B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x000677D6 File Offset: 0x000659D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContentPackageTransferScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000677F3 File Offset: 0x000659F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x000677FC File Offset: 0x000659FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000EF1 RID: 3825
		private static readonly MessageParser<ContentPackageTransferScNotify> _parser = new MessageParser<ContentPackageTransferScNotify>(() => new ContentPackageTransferScNotify());

		// Token: 0x04000EF2 RID: 3826
		private UnknownFieldSet _unknownFields;
	}
}
