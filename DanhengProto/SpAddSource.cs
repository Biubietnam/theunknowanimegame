using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001177 RID: 4471
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpAddSource : IMessage<SpAddSource>, IMessage, IEquatable<SpAddSource>, IDeepCloneable<SpAddSource>, IBufferMessage
	{
		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600C77C RID: 51068 RVA: 0x00217510 File Offset: 0x00215710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpAddSource> Parser
		{
			get
			{
				return SpAddSource._parser;
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600C77D RID: 51069 RVA: 0x00217517 File Offset: 0x00215717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpAddSourceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600C77E RID: 51070 RVA: 0x00217529 File Offset: 0x00215729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpAddSource.Descriptor;
			}
		}

		// Token: 0x0600C77F RID: 51071 RVA: 0x00217530 File Offset: 0x00215730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpAddSource()
		{
		}

		// Token: 0x0600C780 RID: 51072 RVA: 0x00217543 File Offset: 0x00215743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpAddSource(SpAddSource other) : this()
		{
			this.source_ = other.source_;
			this.spAdd_ = other.spAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C781 RID: 51073 RVA: 0x00217574 File Offset: 0x00215774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpAddSource Clone()
		{
			return new SpAddSource(this);
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600C782 RID: 51074 RVA: 0x0021757C File Offset: 0x0021577C
		// (set) Token: 0x0600C783 RID: 51075 RVA: 0x00217584 File Offset: 0x00215784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600C784 RID: 51076 RVA: 0x00217597 File Offset: 0x00215797
		// (set) Token: 0x0600C785 RID: 51077 RVA: 0x0021759F File Offset: 0x0021579F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SpAdd
		{
			get
			{
				return this.spAdd_;
			}
			set
			{
				this.spAdd_ = value;
			}
		}

		// Token: 0x0600C786 RID: 51078 RVA: 0x002175A8 File Offset: 0x002157A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpAddSource);
		}

		// Token: 0x0600C787 RID: 51079 RVA: 0x002175B8 File Offset: 0x002157B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpAddSource other)
		{
			return other != null && (other == this || (!(this.Source != other.Source) && this.SpAdd == other.SpAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C788 RID: 51080 RVA: 0x00217608 File Offset: 0x00215808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Source.Length != 0)
			{
				num ^= this.Source.GetHashCode();
			}
			if (this.SpAdd != 0U)
			{
				num ^= this.SpAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C789 RID: 51081 RVA: 0x00217662 File Offset: 0x00215862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C78A RID: 51082 RVA: 0x0021766A File Offset: 0x0021586A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C78B RID: 51083 RVA: 0x00217674 File Offset: 0x00215874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Source.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Source);
			}
			if (this.SpAdd != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SpAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C78C RID: 51084 RVA: 0x002176D4 File Offset: 0x002158D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Source.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Source);
			}
			if (this.SpAdd != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SpAdd);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C78D RID: 51085 RVA: 0x00217730 File Offset: 0x00215930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpAddSource other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Source.Length != 0)
			{
				this.Source = other.Source;
			}
			if (other.SpAdd != 0U)
			{
				this.SpAdd = other.SpAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C78E RID: 51086 RVA: 0x00217785 File Offset: 0x00215985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C78F RID: 51087 RVA: 0x00217790 File Offset: 0x00215990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SpAdd = input.ReadUInt32();
					}
				}
				else
				{
					this.Source = input.ReadString();
				}
			}
		}

		// Token: 0x04005092 RID: 20626
		private static readonly MessageParser<SpAddSource> _parser = new MessageParser<SpAddSource>(() => new SpAddSource());

		// Token: 0x04005093 RID: 20627
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005094 RID: 20628
		public const int SourceFieldNumber = 1;

		// Token: 0x04005095 RID: 20629
		private string source_ = "";

		// Token: 0x04005096 RID: 20630
		public const int SpAddFieldNumber = 2;

		// Token: 0x04005097 RID: 20631
		private uint spAdd_;
	}
}
