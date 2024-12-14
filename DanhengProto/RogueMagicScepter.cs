using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F01 RID: 3841
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepter : IMessage<RogueMagicScepter>, IMessage, IEquatable<RogueMagicScepter>, IDeepCloneable<RogueMagicScepter>, IBufferMessage
	{
		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0600AB7B RID: 43899 RVA: 0x001CDE80 File Offset: 0x001CC080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepter> Parser
		{
			get
			{
				return RogueMagicScepter._parser;
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0600AB7C RID: 43900 RVA: 0x001CDE87 File Offset: 0x001CC087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0600AB7D RID: 43901 RVA: 0x001CDE99 File Offset: 0x001CC099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepter.Descriptor;
			}
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x001CDEA0 File Offset: 0x001CC0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter()
		{
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x001CDEA8 File Offset: 0x001CC0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter(RogueMagicScepter other) : this()
		{
			this.scepterId_ = other.scepterId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x001CDED9 File Offset: 0x001CC0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter Clone()
		{
			return new RogueMagicScepter(this);
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0600AB81 RID: 43905 RVA: 0x001CDEE1 File Offset: 0x001CC0E1
		// (set) Token: 0x0600AB82 RID: 43906 RVA: 0x001CDEE9 File Offset: 0x001CC0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScepterId
		{
			get
			{
				return this.scepterId_;
			}
			set
			{
				this.scepterId_ = value;
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0600AB83 RID: 43907 RVA: 0x001CDEF2 File Offset: 0x001CC0F2
		// (set) Token: 0x0600AB84 RID: 43908 RVA: 0x001CDEFA File Offset: 0x001CC0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600AB85 RID: 43909 RVA: 0x001CDF03 File Offset: 0x001CC103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepter);
		}

		// Token: 0x0600AB86 RID: 43910 RVA: 0x001CDF11 File Offset: 0x001CC111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepter other)
		{
			return other != null && (other == this || (this.ScepterId == other.ScepterId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x001CDF50 File Offset: 0x001CC150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScepterId != 0U)
			{
				num ^= this.ScepterId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x001CDFA8 File Offset: 0x001CC1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB89 RID: 43913 RVA: 0x001CDFB0 File Offset: 0x001CC1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB8A RID: 43914 RVA: 0x001CDFBC File Offset: 0x001CC1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Level);
			}
			if (this.ScepterId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ScepterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB8B RID: 43915 RVA: 0x001CE018 File Offset: 0x001CC218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScepterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScepterId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB8C RID: 43916 RVA: 0x001CE070 File Offset: 0x001CC270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepter other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScepterId != 0U)
			{
				this.ScepterId = other.ScepterId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB8D RID: 43917 RVA: 0x001CE0C0 File Offset: 0x001CC2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB8E RID: 43918 RVA: 0x001CE0CC File Offset: 0x001CC2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ScepterId = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040045FD RID: 17917
		private static readonly MessageParser<RogueMagicScepter> _parser = new MessageParser<RogueMagicScepter>(() => new RogueMagicScepter());

		// Token: 0x040045FE RID: 17918
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045FF RID: 17919
		public const int ScepterIdFieldNumber = 14;

		// Token: 0x04004600 RID: 17920
		private uint scepterId_;

		// Token: 0x04004601 RID: 17921
		public const int LevelFieldNumber = 3;

		// Token: 0x04004602 RID: 17922
		private uint level_;
	}
}
