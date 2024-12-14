using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000AF RID: 175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArchiveWolfBroGameCsReq : IMessage<ArchiveWolfBroGameCsReq>, IMessage, IEquatable<ArchiveWolfBroGameCsReq>, IDeepCloneable<ArchiveWolfBroGameCsReq>, IBufferMessage
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00015745 File Offset: 0x00013945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArchiveWolfBroGameCsReq> Parser
		{
			get
			{
				return ArchiveWolfBroGameCsReq._parser;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0001574C File Offset: 0x0001394C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ArchiveWolfBroGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0001575E File Offset: 0x0001395E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArchiveWolfBroGameCsReq.Descriptor;
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00015765 File Offset: 0x00013965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveWolfBroGameCsReq()
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00015770 File Offset: 0x00013970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveWolfBroGameCsReq(ArchiveWolfBroGameCsReq other) : this()
		{
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000157BC File Offset: 0x000139BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveWolfBroGameCsReq Clone()
		{
			return new ArchiveWolfBroGameCsReq(this);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x000157C4 File Offset: 0x000139C4
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x000157CC File Offset: 0x000139CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x000157D5 File Offset: 0x000139D5
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x000157DD File Offset: 0x000139DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000157E6 File Offset: 0x000139E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArchiveWolfBroGameCsReq);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000157F4 File Offset: 0x000139F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArchiveWolfBroGameCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.Motion, other.Motion) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00015844 File Offset: 0x00013A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00015899 File Offset: 0x00013A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000158A1 File Offset: 0x00013AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000158AC File Offset: 0x00013AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motion_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Motion);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00015908 File Offset: 0x00013B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00015960 File Offset: 0x00013B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArchiveWolfBroGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000159C8 File Offset: 0x00013BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000159D4 File Offset: 0x00013BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					if (this.motion_ == null)
					{
						this.Motion = new MotionInfo();
					}
					input.ReadMessage(this.Motion);
				}
			}
		}

		// Token: 0x040002D7 RID: 727
		private static readonly MessageParser<ArchiveWolfBroGameCsReq> _parser = new MessageParser<ArchiveWolfBroGameCsReq>(() => new ArchiveWolfBroGameCsReq());

		// Token: 0x040002D8 RID: 728
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002D9 RID: 729
		public const int MotionFieldNumber = 4;

		// Token: 0x040002DA RID: 730
		private MotionInfo motion_;

		// Token: 0x040002DB RID: 731
		public const int IdFieldNumber = 10;

		// Token: 0x040002DC RID: 732
		private uint id_;
	}
}
