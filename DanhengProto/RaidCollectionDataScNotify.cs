using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D63 RID: 3427
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidCollectionDataScNotify : IMessage<RaidCollectionDataScNotify>, IMessage, IEquatable<RaidCollectionDataScNotify>, IDeepCloneable<RaidCollectionDataScNotify>, IBufferMessage
	{
		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0600991E RID: 39198 RVA: 0x001979A9 File Offset: 0x00195BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidCollectionDataScNotify> Parser
		{
			get
			{
				return RaidCollectionDataScNotify._parser;
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x0600991F RID: 39199 RVA: 0x001979B0 File Offset: 0x00195BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidCollectionDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x06009920 RID: 39200 RVA: 0x001979C2 File Offset: 0x00195BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidCollectionDataScNotify.Descriptor;
			}
		}

		// Token: 0x06009921 RID: 39201 RVA: 0x001979C9 File Offset: 0x00195BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataScNotify()
		{
		}

		// Token: 0x06009922 RID: 39202 RVA: 0x001979D1 File Offset: 0x00195BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataScNotify(RaidCollectionDataScNotify other) : this()
		{
			this.collectionInfo_ = ((other.collectionInfo_ != null) ? other.collectionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x00197A06 File Offset: 0x00195C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataScNotify Clone()
		{
			return new RaidCollectionDataScNotify(this);
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x06009924 RID: 39204 RVA: 0x00197A0E File Offset: 0x00195C0E
		// (set) Token: 0x06009925 RID: 39205 RVA: 0x00197A16 File Offset: 0x00195C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KOGBDHNMMDF CollectionInfo
		{
			get
			{
				return this.collectionInfo_;
			}
			set
			{
				this.collectionInfo_ = value;
			}
		}

		// Token: 0x06009926 RID: 39206 RVA: 0x00197A1F File Offset: 0x00195C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidCollectionDataScNotify);
		}

		// Token: 0x06009927 RID: 39207 RVA: 0x00197A2D File Offset: 0x00195C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidCollectionDataScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CollectionInfo, other.CollectionInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009928 RID: 39208 RVA: 0x00197A60 File Offset: 0x00195C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.collectionInfo_ != null)
			{
				num ^= this.CollectionInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009929 RID: 39209 RVA: 0x00197A9C File Offset: 0x00195C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600992A RID: 39210 RVA: 0x00197AA4 File Offset: 0x00195CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x00197AAD File Offset: 0x00195CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.collectionInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CollectionInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x00197AE0 File Offset: 0x00195CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.collectionInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CollectionInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600992D RID: 39213 RVA: 0x00197B20 File Offset: 0x00195D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidCollectionDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.collectionInfo_ != null)
			{
				if (this.collectionInfo_ == null)
				{
					this.CollectionInfo = new KOGBDHNMMDF();
				}
				this.CollectionInfo.MergeFrom(other.CollectionInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600992E RID: 39214 RVA: 0x00197B74 File Offset: 0x00195D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600992F RID: 39215 RVA: 0x00197B80 File Offset: 0x00195D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.collectionInfo_ == null)
					{
						this.CollectionInfo = new KOGBDHNMMDF();
					}
					input.ReadMessage(this.CollectionInfo);
				}
			}
		}

		// Token: 0x04003B73 RID: 15219
		private static readonly MessageParser<RaidCollectionDataScNotify> _parser = new MessageParser<RaidCollectionDataScNotify>(() => new RaidCollectionDataScNotify());

		// Token: 0x04003B74 RID: 15220
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B75 RID: 15221
		public const int CollectionInfoFieldNumber = 4;

		// Token: 0x04003B76 RID: 15222
		private KOGBDHNMMDF collectionInfo_;
	}
}
