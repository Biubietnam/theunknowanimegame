using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AB1 RID: 2737
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MazePropState : IMessage<MazePropState>, IMessage, IEquatable<MazePropState>, IDeepCloneable<MazePropState>, IBufferMessage
	{
		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06007957 RID: 31063 RVA: 0x0014193C File Offset: 0x0013FB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MazePropState> Parser
		{
			get
			{
				return MazePropState._parser;
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x06007958 RID: 31064 RVA: 0x00141943 File Offset: 0x0013FB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MazePropStateReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06007959 RID: 31065 RVA: 0x00141955 File Offset: 0x0013FB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MazePropState.Descriptor;
			}
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x0014195C File Offset: 0x0013FB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MazePropState()
		{
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x00141964 File Offset: 0x0013FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MazePropState(MazePropState other) : this()
		{
			this.state_ = other.state_;
			this.groupId_ = other.groupId_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x001419A1 File Offset: 0x0013FBA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MazePropState Clone()
		{
			return new MazePropState(this);
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x0600795D RID: 31069 RVA: 0x001419A9 File Offset: 0x0013FBA9
		// (set) Token: 0x0600795E RID: 31070 RVA: 0x001419B1 File Offset: 0x0013FBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x0600795F RID: 31071 RVA: 0x001419BA File Offset: 0x0013FBBA
		// (set) Token: 0x06007960 RID: 31072 RVA: 0x001419C2 File Offset: 0x0013FBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x06007961 RID: 31073 RVA: 0x001419CB File Offset: 0x0013FBCB
		// (set) Token: 0x06007962 RID: 31074 RVA: 0x001419D3 File Offset: 0x0013FBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x001419DC File Offset: 0x0013FBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MazePropState);
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x001419EC File Offset: 0x0013FBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MazePropState other)
		{
			return other != null && (other == this || (this.State == other.State && this.GroupId == other.GroupId && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x00141A48 File Offset: 0x0013FC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != 0U)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.ConfigId != 0U)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x00141AB9 File Offset: 0x0013FCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x00141AC1 File Offset: 0x0013FCC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x00141ACC File Offset: 0x0013FCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GroupId);
			}
			if (this.State != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.State);
			}
			if (this.ConfigId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x00141B44 File Offset: 0x0013FD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.State);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.ConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x00141BB4 File Offset: 0x0013FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MazePropState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != 0U)
			{
				this.State = other.State;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.ConfigId != 0U)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x00141C18 File Offset: 0x0013FE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x00141C24 File Offset: 0x0013FE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ConfigId = input.ReadUInt32();
						}
					}
					else
					{
						this.State = input.ReadUInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002E94 RID: 11924
		private static readonly MessageParser<MazePropState> _parser = new MessageParser<MazePropState>(() => new MazePropState());

		// Token: 0x04002E95 RID: 11925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E96 RID: 11926
		public const int StateFieldNumber = 8;

		// Token: 0x04002E97 RID: 11927
		private uint state_;

		// Token: 0x04002E98 RID: 11928
		public const int GroupIdFieldNumber = 5;

		// Token: 0x04002E99 RID: 11929
		private uint groupId_;

		// Token: 0x04002E9A RID: 11930
		public const int ConfigIdFieldNumber = 11;

		// Token: 0x04002E9B RID: 11931
		private uint configId_;
	}
}
