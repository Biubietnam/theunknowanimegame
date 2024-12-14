using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000909 RID: 2313
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HPHCAAAEOMO : IMessage<HPHCAAAEOMO>, IMessage, IEquatable<HPHCAAAEOMO>, IDeepCloneable<HPHCAAAEOMO>, IBufferMessage
	{
		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x0600673A RID: 26426 RVA: 0x00113E24 File Offset: 0x00112024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HPHCAAAEOMO> Parser
		{
			get
			{
				return HPHCAAAEOMO._parser;
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x0600673B RID: 26427 RVA: 0x00113E2B File Offset: 0x0011202B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HPHCAAAEOMOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x0600673C RID: 26428 RVA: 0x00113E3D File Offset: 0x0011203D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HPHCAAAEOMO.Descriptor;
			}
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x00113E44 File Offset: 0x00112044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPHCAAAEOMO()
		{
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x00113E4C File Offset: 0x0011204C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPHCAAAEOMO(HPHCAAAEOMO other) : this()
		{
			this.eventUniqueId_ = other.eventUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x00113E71 File Offset: 0x00112071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPHCAAAEOMO Clone()
		{
			return new HPHCAAAEOMO(this);
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06006740 RID: 26432 RVA: 0x00113E79 File Offset: 0x00112079
		// (set) Token: 0x06006741 RID: 26433 RVA: 0x00113E81 File Offset: 0x00112081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventUniqueId
		{
			get
			{
				return this.eventUniqueId_;
			}
			set
			{
				this.eventUniqueId_ = value;
			}
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00113E8A File Offset: 0x0011208A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HPHCAAAEOMO);
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x00113E98 File Offset: 0x00112098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HPHCAAAEOMO other)
		{
			return other != null && (other == this || (this.EventUniqueId == other.EventUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x00113EC8 File Offset: 0x001120C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006745 RID: 26437 RVA: 0x00113F07 File Offset: 0x00112107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006746 RID: 26438 RVA: 0x00113F0F File Offset: 0x0011210F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x00113F18 File Offset: 0x00112118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x00113F4C File Offset: 0x0011214C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006749 RID: 26441 RVA: 0x00113F8A File Offset: 0x0011218A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HPHCAAAEOMO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x00113FBB File Offset: 0x001121BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x00113FC4 File Offset: 0x001121C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EventUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040027A7 RID: 10151
		private static readonly MessageParser<HPHCAAAEOMO> _parser = new MessageParser<HPHCAAAEOMO>(() => new HPHCAAAEOMO());

		// Token: 0x040027A8 RID: 10152
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027A9 RID: 10153
		public const int EventUniqueIdFieldNumber = 12;

		// Token: 0x040027AA RID: 10154
		private uint eventUniqueId_;
	}
}
